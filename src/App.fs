module AmazingApp

open Fable.Core.JsInterop
open Elmish
open Elmish.Navigation
open Elmish.UrlParser
open Elmish.React
open Elmish.Debug
open Elmish.HMR

// register CSS
importAll "./scss/main.scss"

Program.mkProgram Main.State.init Main.State.update Main.View.root
  |> Program.toNavigable (parseHash Router.pageParser) Main.State.setRoute
  |> Program.withReactBatched "elmish-app"
  |> Program.withConsoleTrace
  |> Program.run

