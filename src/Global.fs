module Global

type Page =
  | Home
  | Food
  | Speakers of speaker: string option
  | Planning
  | Location
  | Venue

let toHash page =
  match page with
  | Location -> "#location"
  | Food -> "#food"
  | Speakers (Some speaker) -> "#speakers/" + speaker
  | Speakers None -> "#speakers"
  | Planning -> "#planning"
  | Venue -> "#venue"
  | Home -> "#home"
