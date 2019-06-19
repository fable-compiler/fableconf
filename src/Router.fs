module Router

open Fable.React.Props
open Elmish.Navigation
open Elmish.UrlParser

[<RequireQualifiedAccess>]
type Route =
  | Home
  | Agenda

let toHash page =
  match page with
  | Route.Agenda -> "#agenda"
  | Route.Home -> "#home"

let pageParser: Parser<Route->Route,_> =
  oneOf [
    map Route.Agenda (s "agenda")
    map Route.Home (s "home")
  ]

let href route =
  Href (toHash route)

let modifyUrl route =
  route |> toHash |> Navigation.modifyUrl

let newUrl route =
  route |> toHash |> Navigation.newUrl
