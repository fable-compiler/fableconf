module Global

type Page =
  | Home
  | Speakers
  | Location

let toHash page =
  match page with
  | Location -> "#location"
  | Speakers -> "#speakers"
  | Home -> "#home"
