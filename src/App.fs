module App.View

open Elmish
open Elmish.Browser.Navigation
open Elmish.Browser.UrlParser
open Fable.Core.JsInterop
open Types
open App.State
open Global

importAll "../sass/main.sass"

open Fable.Helpers.React
open Fable.Helpers.React.Props

let root model dispatch =

  let pageHtml =
    function
    | Location -> Info.View.root
    | Planning -> Planning.View.root model.planning (PlanningMsg >> dispatch)
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
          a [Href "http://www.biensurgraphisme.com";Target "_blank"] [ span [Class "neon-green"] [str " web design by Biensür Graphisme"]]
        ]
    ]

open Elmish.React

// App
Program.mkProgram init update root
|> Program.toNavigable (parseHash pageParser) urlUpdate
|> Program.withReact "elmish-app"
|> Program.run
