module AmazingApp

open Fable.Core.JsInterop
open Elmish
open Elmish.Navigation
open Elmish.UrlParser
open Elmish.React
open Elmish.Debug
open Elmish.HMR

Program.mkProgram Main.State.init Main.State.update Main.View.root
  |> Program.toNavigable (parseHash Router.pageParser) Main.State.setRoute
  |> Program.withReactSynchronous "elmish-app"
#if DEBUG
  |> Program.withConsoleTrace
#endif
  |> Program.run

