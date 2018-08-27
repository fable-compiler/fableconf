#r "packages/build/FAKE/tools/FakeLib.dll"
#r "System.IO.Compression.FileSystem"

open System
open System.IO
open System.Text.RegularExpressions
open Fake.Git
open Fake

#if MONO
// prevent incorrect output encoding (e.g. https://github.com/fsharp/FAKE/issues/1196)
System.Console.OutputEncoding <- System.Text.Encoding.UTF8
#endif

module Util =

    let run workingDir fileName args =
        printfn "CWD: %s" workingDir
        let fileName, args =
            if EnvironmentHelper.isUnix
            then fileName, args else "cmd", ("/C " + fileName + " " + args)
        let ok =
            execProcess (fun info ->
                info.FileName <- fileName
                info.WorkingDirectory <- workingDir
                info.Arguments <- args) TimeSpan.MaxValue
        if not ok then failwith (sprintf "'%s> %s %s' task failed" workingDir fileName args)

    let visitFile (visitor: string->string) (fileName : string) =
        File.ReadAllLines(fileName)
        |> Array.map (visitor)
        |> fun lines -> File.WriteAllLines(fileName, lines)

    let replaceLines (replacer: string->Match->string option) (reg: Regex) (fileName: string) =
        fileName |> visitFile (fun line ->
            let m = reg.Match(line)
            if not m.Success
            then line
            else
                match replacer line m with
                | None -> line
                | Some newLine -> newLine)

let root = __SOURCE_DIRECTORY__

let gitOwner = "fable-compiler"
let gitProject = "fableconf"

let mutable dotnetExePath = environVarOrDefault "DOTNET" "dotnet"

let findLineAndGetGroupValue regexPattern (groupIndex: int) filePath =
    let reg = Regex(regexPattern)
    File.ReadLines(filePath)
    |> Seq.pick (fun line ->
        let m = reg.Match(line)
        if m.Success
        then Some m.Groups.[groupIndex].Value
        else None)

Target "Clean" (fun () ->
    !! "src/**/bin" ++ "src/**/obj/" |> CleanDirs
)

Target "InstallDotNetSdk"  (fun () ->
    let dotnetcliVersion =
        Path.Combine(__SOURCE_DIRECTORY__, "global.json")
        |> findLineAndGetGroupValue "\"version\": \"(.*?)\"" 1

    dotnetExePath <- DotNetCli.InstallDotNetSDK dotnetcliVersion
)

Target "Restore" (fun () ->
    Util.run root "yarn" "install"
    Util.run (root </> "src") dotnetExePath "restore"
)

Target "Build" (fun () ->
    Util.run (root </> "src") dotnetExePath "fable yarn-build"
)

let bumpVersion() =
    let mutable newVersion = 0
    let reg = Regex(@"\?v=(\d+)")
    let mainFile = root </> "public/index.html"
    (reg, mainFile) ||> Util.replaceLines (fun line m ->
        newVersion <- (int m.Groups.[1].Value) + 1
        reg.Replace(line, sprintf "?v=%i" newVersion) |> Some)
    newVersion

let commit workingDir files message =
    match files with
    | Some files -> files |> List.iter (StageFile workingDir >> ignore)
    | None -> StageAll workingDir
    Git.Commit.Commit workingDir message

let commitAndPush workingDir files message =
    commit workingDir files message
    Branches.push workingDir

Target "Publish" (fun () ->
    let publishBranch = "gh-pages"
    let publishDir, tempDir = root </> "public", root </> "temp"
    let githubLink = sprintf "https://github.com/%s/%s.git" gitOwner gitProject

    let newVersion = bumpVersion()
    sprintf "Bump version (%i)" newVersion
    |> commit root (Some [root </> "public/index.html"])

    CleanDir tempDir
    Repository.cloneSingleBranch root githubLink publishBranch tempDir
    CopyRecursive publishDir tempDir true |> ignore
    sprintf "Update site (v%i)" newVersion
    |> commitAndPush tempDir None
)

"Clean"
==> "InstallDotNetSdk"
==> "Restore"
==> "Build"
==> "Publish"

// Start build
RunTargetOrDefault "Build"
