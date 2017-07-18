module Global

type Page =
  | Home
  | Food
  | Speakers of speaker: string option
  | Location

let toHash page =
  match page with
  | Location -> "#location"
  | Food -> "#food"
  | Speakers (Some speaker) -> "#speakers/" + speaker
  | Speakers None -> "#speakers"
  | Home -> "#home"
