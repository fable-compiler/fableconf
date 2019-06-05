module Types 

[<RequireQualifiedAccess>]
type Route =
  | About
  | Schedule

type Speaker =
  {
    shortname: string
    name: string
    picture: string
    bio: string option
    twitter: string option
    links : (string * string) list
    github: string option
  }

type Talk =
  { Title: string
    Video : string option
    Speakers: Speaker list
    Content: Fable.React.ReactElement }