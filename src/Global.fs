module Global

type Page =
  | Home
  | Speakers of speaker: string option
  | Location

let toHash page =
  match page with
  | Location -> "#location"
  | Speakers (Some speaker) -> "#speakers/" + speaker
  | Speakers None -> "#speakers"
  | Home -> "#home"
