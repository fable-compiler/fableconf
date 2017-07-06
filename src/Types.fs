module App.Types

open Global

type Msg =
  | SpeakersMsg of Speakers.Types.Msg
  | HomeMsg of Home.Types.Msg

type Model = {
    currentPage: Page
    speakers: Speakers.Types.Model
    home: Home.Types.Model
  }
