module App.View

open Elmish
open Elmish.Browser.Navigation
open Elmish.Browser.UrlParser
open Fable.Core
open Fable.Core.JsInterop
open Fable.Import
open Fable.Import.Browser
open Types
open App.State
open Global

importAll "../sass/main.sass"

open Fable.Helpers.React
open Fable.Helpers.React.Props

(*
let menuItem label page currentPage =
    li
      [ ]
      [ a
          [ classList [ "is-active", page = currentPage ]
            Href (toHash page) ]
          [ str label ] ]

let menu currentPage =
  aside
    [ Class "menu" ]
    [ p
        [ Class "menu-label" ]
        [ str "General" ]
      ul
        [ Class "menu-list" ]
        [ menuItem "Home" Home currentPage
          menuItem "Speakers" (Speakers None) currentPage
          menuItem "Location" Page.Location currentPage ] ]
*)

let root model dispatch =

  let pageHtml =
    function
    | Location -> Info.View.root
    | Planning -> Planning.View.root model.planning (PlanningMsg >> dispatch)
    // | Food -> Food.View.root
    // | Speakers speaker -> Speakers.View.root model.speakers
    | Home | _ -> Home.View.root model.home (HomeMsg >> dispatch)

  div
    []
    [ div
        [ Class "navbar-bg" ]
        [ Navbar.View.root model.currentPage model.navbar (NavbarMsg >> dispatch) ]
      pageHtml model.currentPage
      div
        [ Class "footer footer-bg" ]
        [
          span [Class "title-bold"] [
            str "FABLE "
          ]
          span [Class "parisienne neon-green"] [
            str "Conf'18"
          ]
          span [] [str " is organised with passion and dedication by fellow Fsharpists!"]
          a [Href "http://www.biensuratelier.com/graphisme.html";Target "_blank"] [ span [Class "neon-green"] [str " web design by Atelier BIENSÜR Graphisme"]]
        ]
    ]

open Elmish.React

// App
Program.mkProgram init update root
|> Program.toNavigable (parseHash pageParser) urlUpdate
|> Program.withReact "elmish-app"
|> Program.run
