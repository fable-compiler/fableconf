module Global

open Fable.Import.React

type Page =
  | Home
  | Location
  | Planning

let toHash page =
  match page with
  | Planning -> "#planning"
  | Location -> "#location"
  | Home -> "#home"

type Talk =
  { title: string; content: ReactElement }


type Speaker =
  {
    shortname: string
    name: string
    picture: string
    talk: Talk
    bio: string option
    twitter: string option
    github: string option
  }
