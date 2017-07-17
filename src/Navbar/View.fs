module Navbar.View

open Fable.Core.JsInterop
open Fable.Helpers.React
open Fable.Helpers.React.Props
open Elmish.Bulma.Components
open Elmish.Bulma.Elements.Form
open Global
open Types

let navButton classy href faClass txt =
  Control.control [ ]
    [ a [ ClassName (sprintf "button %s" classy)
          Href href ]
        [ span
            [ ClassName "icon" ]
            [ i
                [ ClassName (sprintf "fa %s" faClass) ]
                [ ] ]
          span
            [ ]
            [ str txt ] ] ]

let navButtons =
  div [ClassName "navbar-item"]
    [ Field.field [ Field.isGroupedLeft ]
        [ navButton "twitter" "https://twitter.com/FableCompiler" "fa-twitter" "Twitter"
          navButton "github" "https://gitter.im/fable-compiler/Fable" "fa-comments" "Gitter" ] ]

let menuItem label page currentPage =
    a [
      classList ["navbar-item", true; "is-active", page = currentPage]
      Href (toHash page)
    ] [str label]

let root currentPage (model: Model) dispatch =
  nav [ClassName "navbar"] [
    div [ClassName "navbar-brand"] [
      div [ClassName "navbar-item title is-4"] [str "FableConf 2017"]
      div [
        ClassName "navbar-burger"
        OnClick (fun _ -> dispatch ToggleBurger)
      ] [
        span [] []
        span [] []
        span [] []
      ]
    ]
    div [classList ["navbar-menu", true; "is-active", model.isBurgerOpen]] [
      div [ClassName "navbar-start"] [
        menuItem "Home" Home currentPage
        menuItem "Speakers" (Speakers None) currentPage
        menuItem "Location" Page.Location currentPage
      ]
      div [ClassName "navbar-end"] [navButtons]
    ]
  ]
