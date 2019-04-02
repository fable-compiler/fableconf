module Router

open Types
open Fable.Import
open Fable.Helpers.React.Props
open Elmish.Browser.Navigation
open Elmish.Browser.UrlParser

let private toHash (page:Route) =
  
  match page with
  | Route.About -> "#about"
  | Route.Schedule -> "#schedule"

let pageParser: Parser<Route->Route,_> =
  
  oneOf [
    map Route.About (s "about")
    map Route.Schedule (s "schedule")
  ]

let href route =
  Href (toHash route)

let modifyUrl route =
  route |> toHash |> Navigation.modifyUrl

let newUrl route =
//  route |> toHash |> Navigation.modifyUrl
  route |> toHash |> Navigation.newUrl

let modifyLocation route =
  Browser.window.location.href <- toHash route
