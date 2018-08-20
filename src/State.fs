module App.State

open Elmish
open Elmish.Browser.Navigation
open Elmish.Browser.UrlParser
open Fable.Import.Browser
open Global
open Types

let pageParser: Parser<Page->Page,Page> =
  oneOf [
    map Location (s "location")
    map Food (s "food")
    //map (Some >> Speakers) (s "speakers" </> str)
    map (Speakers None) (s "speakers")
    map Home (s "home")
  ]

let urlUpdate (result: Option<Page>) model =
  match result with
  | None ->
    console.error("Error parsing url")
    model, Navigation.modifyUrl (toHash model.currentPage)
  | Some(Speakers(Some speaker)) ->
      let modal =
        let speaker = Speakers.Types.speakersMap |> Map.find speaker
        Some(speaker, speaker.talk)
      let speakers = { model.speakers with modal = modal }
      { model with speakers = speakers; currentPage = Speakers (Some speaker) }, []
  | Some(Speakers None) ->
      let speakers = { model.speakers with modal = None }
      { model with speakers = speakers; currentPage = Speakers None }, []
  | Some page ->
    { model with currentPage = page }, []

let init result =
  let speakers = Speakers.State.init()
  let (navbar, navCmd) = Navbar.State.init()
  let (home, homeCmd) = Home.State.init()
  let (model, cmd) =
    urlUpdate result
      { currentPage = Home
        navbar = navbar
        speakers = speakers
        home = home }
  model, Cmd.batch [ cmd
                     Cmd.map NavbarMsg navCmd
                     Cmd.map HomeMsg homeCmd ]

let update msg model =
  match msg with
  | NavbarMsg msg ->
      let (navbar, navbarCmd) = Navbar.State.update msg model.navbar
      { model with navbar = navbar }, Cmd.map NavbarMsg navbarCmd
  | HomeMsg msg ->
      let (home, homeCmd) = Home.State.update msg model.home
      { model with home = home }, Cmd.map HomeMsg homeCmd
