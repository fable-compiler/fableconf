namespace Page

module Schedule =
  open Types
  open Fable.React
  open Speakers


  module Types =

    type EventKind = TrackOne | TrackTwo | Keynote | Lightning

    type Level = Beginner | Intermediate | Expert | AllLevels

    type Track =
      {
        Title:string
        Talk:Talk option
        Kind:EventKind option
        Level:Level option
      }

    type DayEvent =
      {
        Time:string
        Tracks:Track list
      }

    type Day =
      {
        Date:string
        SubtitleLink: (string*string) option
        Events : DayEvent list
      }

    type Model =
      { Days: Day list
        Highlight: Speaker option }

    type Msg =
      | OpenModal of Speaker
      | CloseModal

    let initialModel =
      let takeABreak title time =
          {Time=time; Tracks=[{Level=None;Talk=None;Title=title;Kind=None}]}

      let eventFromSpeaker talk kind level =
        {
          Talk=Some talk
          Title=talk.Title
          Kind=Some kind
          Level = Some level
        }

      let track1 talk=
        eventFromSpeaker talk TrackOne

      let track2 talk =
        eventFromSpeaker talk TrackTwo

      let keynote talk =
        eventFromSpeaker talk Keynote

      let lightning talk =
        eventFromSpeaker talk Lightning

      let days =
        [
          {
            Date="Day One - Friday 6 Sept."
            SubtitleLink=None //Some ("Registration for dinner", "https://docs.google.com/forms/d/e/1FAIpQLSfdnhr1UOziLLfqKbAmdywHE1o4GY4GjIqUQN0xxES7dfuPpA/viewform")
            Events=[
              {Time="TRACKS"; Tracks=[{Level=None;Talk=None;Title="Track A";Kind=Some TrackOne};{Level=None;Talk=None;Title="Track B";Kind=Some TrackTwo}]}
              takeABreak "Introductory Breakfast" "08:15"
              {
                Time="09:15"
                Tracks=[
                  keynote
                    {
                      Title="Keynote: The Joys of OSS"
                      Video=None
                      Speakers=[Speakers.Zaid]
                      Content=str "TBD"
                    }
                    AllLevels
                ]
              }
              takeABreak "Coffee Break" "10:15"
              { Time="10:30"
                Tracks=[
                  track1
                    {
                      Title="A Journey into the Compiler and Tooling"
                      Video=None
                      Speakers=[Speakers.Florian]
                      Content=str "TBD"
                    }
                    Intermediate
                  track2
                    {
                      Title="Release the Magic with Reactive MVU"
                      Video=None
                      Speakers=[Speakers.Dag]
                      Content=str """The Model View Update (MVU) pattern, also known as "The Elm Architecture" is getting increasingly popular thanks to Elm and Fable/Elmish (F#). In MVU the model is updated in a purely functional and predictable way enabling safer, debuggable and bug free applications.

Elmish Streams is an implementation of Async Observables in F# and takes event handling in MVU to a higher level by combining the worlds of MVU with reactive programming and Async Observables. The real magic however is that different event processing pipelines may be subscribed or disposed based on the current model. This enables powerful event handling while effectively solving the lifetime management of ongoing web requests, mouse-moves or web sockets that may occur in single page web applications.

During the talk I will also show how web applications using Elmish Streams can be scaled and made hierarchical, enabling reactive components to be reused as sub-components without the need for code changes."""
                    }
                    Intermediate
                ]
              }
              takeABreak "Coffee Break" "11:15"
              { Time="11:30"
                Tracks=[
                  track1
                    {
                      Title="Too Old for JavaScript, Still Young for Elmish"
                      Video=None
                      Speakers=[Speakers.Vagif]
                      Content=str """I am a backend developer, and I always have enough backend-related cards on our Kanban board, so how could I squeeze into it a Web UI task using Fable that I really really wanted to do? But when we migrated our service event store from MongoDB to Azure and needed to have an eye on the new system, I realized it's now or never. If I manage to quickly build a decent UI for a new event store, it may be appreciated, and not only I will be forgiven - we will have a strong case to promote Fable into our organization where F# is already used by a large number of developers. In this talk I will show how little time and code it took to build a Web app using Fable, Fable.Elmish and Fulma, what obstacles newcomers can face and what else we can use Fable for in our organization - and you might consider in yours."""
                    }
                    Beginner
                  track2
                    {
                      Title="Functional Adventures on High-Performance Computer Graphics"
                      Video=None
                      Speakers=[Speakers.Georg]
                      Content=str """Functional programming finally made it from academia to web applications e.g. via react, elm or fable.
Over the last couple of years we worked on the idea of bringing functional programming to high-performance computer graphics.
Our approach on easy to use programming interfaces while not giving back on performance builds on domain-specific-languages, compilers, incremental evaluation.
In this talk we share some of our experience and lessons learned in the aardvark plaform:

- In the first part we give an overview on conceptual and technical modules needed for a functional-first, high-performance rendering engine.
- In the second part we more dive into the field of approachable GPU programming using the FShade language.
- Recently, we ported a substantial part of the rendering engine to Fable. In this last part we want to discuss the status and future steps in that the direction as community activities."""
                    }
                    Expert
                ]
              }
              takeABreak "Lunch" "12:15"
              { Time="14:00"
                Tracks=[
                  track1
                    {
                      Title="Building F# Tooling"
                      Video=None
                      Speakers=[Speakers.Krzysztof]
                      Content=str """TBD"""
                    }
                    AllLevels
                  track2
                    {
                      Title="Web Remote Control"
                      Video=None
                      Speakers=[Speakers.Tomasz]
                      Content=str """Datto Remote Management and Monitoring (RMM) is the platform of choice for thousands of Managed Service Providers to administrate large computer networks. "Web Remote Control" is a new application within RMM kit, implemented using Fable and Elmish, that allows to establish Remote Control & Takeover connections directly from a browser. During this session we'll explore its set of handy features, discuss technical challenges of interacting with JS libraries and sharing F# code with Agents running on the end computers."""
                    }
                    Intermediate
                ]
              }
              takeABreak "Coffee Break" "14:45"
              { Time="15:00"
                Tracks=[
                  track1
                    {
                      Title="From I to X: Simple Tricks to Improve User Experience"
                      Video=None
                      Speakers=[Speakers.Gien]
                      Content=str "TBD"
                    }
                    AllLevels
                  track2
                    {
                      Title="Fable Breakout: Beyond Elmish"
                      Video=None
                      Speakers=[Speakers.Joerg]
                      Content=str """Up to now Fable has been most associated with web development via the Elish ecosystem. However the there are other domains were the language to could be usefully applied. This talk will explore three:
1. Use of Fable for developing CloudFlare Workers. This part of the talk will be based on this: https://github.com/jbeeko/cfworker-hello-world
2. Use of Fable for developing CosmosDB stored procedures. Currently writing these is a terrible experience. Allowing these to be written using Fable could much improve the experience. It may also be possible share code between client and the stored procedures.
3. Use of Fable for concurrent programming. Erlang has been very successful with the Actor model of programming. Something similar could be done with Fable by making FSharp Mailbox processors separate workers using the browser worker interface. Each Mailbox processor will run as a worker on a separate thread."""
                    }
                    Expert
                ]
              }
              takeABreak "Coffee Break" "15:45"
              { Time="16:15"
                Tracks=[
                  lightning
                    {
                      Title="Intensive browser computation and Fable"
                      Video=None
                      Speakers=[Speakers.Colin]
                      Content=str "For some applications you want to run computationally intensive code in the browser due to cost, privacy, or simplicity. What are some options? How can you use Web Workers in Fable to run your F# in parallel and use external C++ code via WebAssembly?"
                    }
                    Expert
                ]
              }
              { Time="16:30"
                Tracks=[
                  lightning
                    {
                      Title="Type-safe Server & Client Communication"
                      Video=None
                      Speakers=[Speakers.Brett]
                      Content=str "Let's see Fable.Remoting in action and also how full-stack F# allows you to share crutial information between your client and server, like routes."
                    }
                    Beginner
                ]
              }
              { Time="16:45"
                Tracks=[
                  lightning
                    {
                      Title="Fable 2029"
                      Video=None
                      Speakers=[Speakers.François; Speakers.Alfonso]
                      Content=str "It's 2019 and Fable has risen to world dominance becoming the only way to write programs. In an unprecedent research of Software History, we will review the series of events that have led to this outcome (humorous)."
                    }
                    AllLevels
                ]
              }
    //          takeABreak "Last Coffee Break" "17:00"
              { Time="17:00"
                Tracks=[
                  keynote
                    {
                      Title="Closing Keynote"
                      Video=None
                      Speakers=[]
                      Content=str "TBD"
                    }
                    AllLevels
                ]
              }
              takeABreak "That's all folks!" "17:30"
            ]
          }
          {
            Date="Day Two - Saturday 7 Sept."
            SubtitleLink=None //Some ("Registration for morning workshops", "https://docs.google.com/forms/d/e/1FAIpQLSftL4EzYUHuiwgLdqQqkDJuBR-g_GVrIqrK-OdHNPHLtWtr-g/viewform")
            Events=[
              {Time="TRACKS"; Tracks=[{Level=None;Talk=None;Title="Workshops I";Kind=Some TrackOne};{Talk=None;Title="Workshops II";Kind=Some TrackTwo;Level=None}]}
              { Time="09:00"
                Tracks=[
                  track1
                    {
                      Title="Interop with Fable: a Deep Dive"
                      Video=None
                      Speakers=[Speakers.Zaid]
                      Content=str "An in-depth workshop on Interop with Fable, how to integrate with exisiting libraries from the Javascript ecosystem, wrapping the API's around safe functions and libraries to be used in Fable applications."
                    }
                    Beginner
                  track2
                    {
                      Title="Build an Azure Storage Account Manager with SAFE"
                      Video=None
                      Speakers=[Speakers.Brett]
                      Content=str "When businesses learn how easy it is to set up Azure Storage Accounts, and that they are free to create, everybody wants some! Let’s build a storage account manager website using the .NET Azure SDKs, the Giraffe Web Server, and a SPA using Fable and Elmish."
                    }
                    Intermediate
                ]
              }
              { Time="11:30"
                Tracks=[
                  track1
                    {
                      Title="Take React's performance to its Fullest"
                      Video=None
                      Speakers=[Speakers.Julien]
                      Content=str "TBD"
                    }
                    Beginner
                  track2
                    {
                      Title="Remove server/client boundaries with Elmish.Bridge"
                      Video=None
                      Speakers=[Speakers.Diego]
                      Content=str "TBD"
                    }
                    Intermediate
                ]
              }
              takeABreak "Lunch" "13:15"
              { Time="14:00"
                Tracks=[
                  track1
                    {
                      Title="Mindful Programming"
                      Video=None
                      Speakers=[Speakers.François]
                      Content=str "TBD"
                    }
                    AllLevels
                  track2
                    {
                      Title="Mastering Server Side Rendering"
                      Video=None
                      Speakers=[Speakers.Steffen]
                      Content=str "TBD"
                    }
                    Intermediate
                ]
              }
              takeABreak "That's all folks! Have fun in Antwerpen!" "17:30"
            ]
        }]

      { Days = days; Highlight = None }


  module State =

    open Types
    open Elmish

    let update msg model =
      match msg with
      | OpenModal s -> { model with Highlight = Some s }, Cmd.none
      | CloseModal -> { model with Highlight = None }, Cmd.none

  module View =

    open Types
    open Fulma
    open Fable.Core.JsInterop
    open Fable.React
    open Fable.React.Props
    open ReactReveal

    let cover =
        div [ Class "landing" ] [
          fade [
            div [ Class "inner" ] [
              div [ Class "info" ] [
                div [Class "ftitle"] [
                  div [Class "top"] [str "FABLE"]
                  div [Class "bottom"] [str "CONF'19"]
                ]
                div [Class "dates"] [
                  div [ Class "top"] [ str "6/7 sept 2019" ]
                  div [ Class "bottom"] [
                      strong [] [str "Schedule" ]
                  ]
                ]
              ]
              div [ Class "axxesLogo" ] [
                div [] [ strong [] [ str "powered by"] ]
                a [ Href "https://axxes.com/"; Target "_blank" ]
                  [ img [ Src "./axxesLogo.png" ] ]
              ]
            ]
          ]
        ]

    let agenda model dispatch=
      let prepareDay dispatch (day:Day) =
        let buildEvent i (event:DayEvent) =
          let count = float event.Tracks.Length
          let max = int (System.Math.Floor ( 10. / count))
          let columnWidth = sprintf "is-%i" max
          let columnClass = sprintf "column column-with-border %s " columnWidth
          let lines =
            event.Tracks
              |> List.map( fun track ->
                let kindClass, kindName, color =
                  match track.Kind with
                  | Some kind ->
                    match kind with
                    | TrackOne ->
                      "subtitle", " //////", "#bb4321"
                    | TrackTwo ->
                      "blue", " //////", "#5b97b4"
                    | _ ->
                      "", "", ""
                  | None -> "","", ""

                let title =
                  Heading.h4 [
                    Heading.Props [
                      Style[
                        Padding "0"
                        Margin "0"
                        FontWeight "600"
                        Color color
                      ]
                    ]
                  ] [
                    str track.Title
                    span [Class kindClass] [str kindName]
                  ]

                let speakerName =
                  match track.Talk with
                  | Some talk ->
                    talk.Speakers
                      |> List.map( fun s ->
                        h6 [Class (sprintf "%s is-6 title-light " kindClass)
//  TODO: Enable when bios are complete
                            OnClick (fun _ ->  OpenModal s |> dispatch)
                            Style [
                              Cursor "pointer"
                              Padding "0"
                              Margin "0"
                              MarginTop "0.5rem"
                              TextTransform "uppercase"
                              Color "black"]]
                          [str s.name]
                      )
                      |> fragment []
                    | None -> fragment [] []

                let tag =
                  match track.Level with
                  | Some level ->
                    match level with
                    | AllLevels ->
                      Tag.tag [ Tag.CustomClass "all"] [str "All Levels"]
                    | Beginner ->
                      Tag.tag [ Tag.CustomClass "beginner"] [str "Beginner"]
                    | Intermediate ->
                      Tag.tag [ Tag.CustomClass "intermediate"]  [str "Intermediate"]
                    | Expert ->
                      Tag.tag [ Tag.CustomClass "expert"]  [str "Expert"]
                  | None -> str ""


                let videoLink =
                  match track.Talk with
                  | Some t ->
                    match t.Video with
                    | Some v ->
                      div [] [
                        a [Class "tag is-Light"; Href v] [str "Video"]
                        str " "
                        tag
                      ]
                    | None -> tag
                  | None -> tag

                let contents =
                  match track.Talk with
                  | None -> [nothing]
                  | Some talk -> [
                    br []
                    div [ClassName "contents"] [talk.Content]
                  ]

                div[
                  Class columnClass
                  Style [
                    BorderLeft "1px solid rgba(0,0,0,0.2)"
                  ]
                ] (title :: speakerName :: contents @ [videoLink])
              )

          let color = if i % 2 = 0 then "lighter" else "darker"
          Columns.columns
            [
              Columns.CustomClass color
              Columns.Props [
                Style [
                  Color "white"
                ]
              ]
            ]
            ([
              Column.column [
                Column.Width (Screen.All, Column.Is2)
              ][
                  Heading.h4 [
                    Heading.Modifiers [
                      Modifier.TextAlignment (Screen.All,TextAlignment.Centered)
                    ]
                  ] [str event.Time]
              ]
            ] @ lines)

        div[
          Class "container day"
        ]
          [
            yield Heading.h3 [
              Heading.Props [
                Style [
                  Margin "1.2rem"
                  //Color "#bb4321"
                ]
              ]
            ] [str day.Date]
            match day.SubtitleLink with
            | Some(txt,url) ->
              yield h4 [Class "subtitle is-4"] [a [Href url] [
                span [Style [TextDecoration "underline"]] [str txt]]]
            | None -> ()
            yield fragment [] (day.Events |> List.mapi buildEvent)
          ]

      let cardView (speaker: Speaker) =
        div [Class "card"] [
          div [Class "card-image"] [
            Image.image [] [
              img [
                Src speaker.picture
                Style [
                  CSSProp.Width "auto"
                  CSSProp.Height "auto"
                  MaxHeight "300px"
                  MaxWidth "300px"
                  Margin "auto"
                ]
              ]
            ]
          ]
          div [Class "card-content"] [
            yield p [Class "title is-4 has-text-centered"] [str speaker.name]
            //yield p [Class "subtitle is-6 has-text-centered"] [str speaker.talk.title]
            match speaker.bio with
            | Some bio -> yield p [] [str bio]
            | None -> ()
            yield div [
              Class "level is-mobile"
              Style [MarginTop "20px"]
            ] [
              speaker.twitter |> Option.map (fun username ->
                a [Class "level-item"; Href ("https://twitter.com/" + username) ] [
                  Icon.icon [Icon.Size Size.IsMedium] [i [Class "fab fa-twitter fa-2x"] []]
                ]) |> ofOption
              speaker.github |> Option.map (fun username ->
                a [Class "level-item"; Href ("https://github.com/" + username) ] [
                  Icon.icon [Icon.Size Size.IsMedium] [i [Class "fab fa-github fa-2x"] []]
                ]) |> ofOption
            ]
          ]
        ]

      let events =
        model.Days
        |> List.map (prepareDay dispatch)

      fragment [] [
          match model.Highlight with
          | Some speaker ->
            yield Modal.modal [ Modal.IsActive true ]
              [ Modal.background [ Props [ OnClick (fun _ -> dispatch CloseModal) ] ] [ ]
                Modal.content [ ]
                  [ Box.box' [ ]
                      [ cardView speaker ] ]
                Modal.close [ Modal.Close.Size IsLarge
                              Modal.Close.OnClick (fun _ -> dispatch CloseModal) ] [ ] ]
          | None -> ()

          yield div[ Class "container planning"]
              //h1 [Class "title is-1 title-bold"] [str "Agenda."]
              events
      ]

    let footer =
      let cesure =
          Level.item [ Level.Item.Modifiers [ Modifier.IsHidden (Screen.Mobile, true)]] [ str "|"]

      Footer.footer[ Props [ Id "footer"] ][
        Level.level [
        ] [
          Level.item [] [
            span [] [
              str "web design by "
              a [ Href "https://biensurgraphisme.com"; Target "_blank"] [ strong [] [str " Biensür Graphisme"] ]
            ]
          ]
          cesure
          Level.item [] [
            span [] [
              str "FABLE CONF is organised by Fable lovers. Powered this year by "
              a [ Href "https://axxes.com/"; Target "_blank"] [ str " Axxes!"]
            ]
          ]
        ]
      ]

    let root model dispatch =
      div [
        ClassName "addMargins"
      ] [
        cover
        agenda model dispatch
        footer
      ]
