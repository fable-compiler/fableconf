module AmazingApp

open Fable.Core.JsInterop
open Elmish
open Elmish.Browser.Navigation
open Elmish.Browser.UrlParser
open Elmish.React
open Elmish.Debug
open Elmish.HMR
open Fable.PowerPack
open Fable.Import
open Fable.PowerPack
open Fable.PowerPack.Fetch
open Fable.PowerPack.Result
open Fable.Import

// register CSS
importAll "./scss/main.scss"

Program.mkProgram Main.State.init Main.State.update Main.View.root
  |> Program.toNavigable (parseHash Router.pageParser) Main.State.setRoute
  |> Program.withReact "elmish-app"
  |> Program.withConsoleTrace
  |> Program.run

