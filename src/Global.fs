module Global

type Page =
  | Home
  | Location
  // | Food
  // | Speakers of speaker: string option
  // | Planning
  // | Venue

let toHash page =
  match page with
  // | Food -> "#food"
  // | Speakers (Some speaker) -> "#speakers/" + speaker
  // | Speakers None -> "#speakers"
  // | Planning -> "#planning"
  // | Venue -> "#venue"
  | Location -> "#location"
  | Home -> "#home"
