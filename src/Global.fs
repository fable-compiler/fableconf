module Global

open Fable.Import.React

type Page =
  | Home
  | Location
  // | Food
  // | Speakers of speaker: string option
  | Planning
  // | Venue

let toHash page =
  match page with
  // | Food -> "#food"
  // | Speakers (Some speaker) -> "#speakers/" + speaker
  // | Speakers None -> "#speakers"
  // | Planning -> "#planning"
  // | Venue -> "#venue"
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
