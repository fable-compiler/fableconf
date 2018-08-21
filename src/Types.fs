module App.Types

open Global

type Msg =
  | HomeMsg of Home.Types.Msg
  | NavbarMsg of Navbar.Types.Msg
  | PlanningMsg of Planning.Types.Msg

type Model = {
    currentPage: Page
    navbar: Navbar.Types.Model
    speakers: Speakers.Types.Model
    planning: Planning.Types.Model
    home: Home.Types.Model
  }
