module Navbar.View

open Fable.Helpers.React
open Fable.Helpers.React.Props
open Elmish.Bulma.Components
open Elmish.Bulma.Elements.Form
open Global

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
  Nav.item [ ]
    [ Field.field [ Field.isGroupedLeft ]
        [ navButton "twitter" "https://twitter.com/FableCompiler" "fa-twitter" "Twitter"
          navButton "github" "https://gitter.im/fable-compiler/Fable" "fa-comments" "Gitter" ] ]

let menuItem label page currentPage =
    a [
      classList [ "navbar-item", true; "is-active", page = currentPage ]
      Href (toHash page)
    ] [str label]

let root currentPage =
  nav [ClassName "navbar"] [
    div [ClassName "navbar-brand"] [
      h1 [ClassName "nav-item is-brand title is-4"] [str "FableConf 2017"]
    ]

    div [ClassName "navbar-menu"] [
      div [ClassName "navbar-start"] [
        menuItem "Home" Home currentPage
        menuItem "Speakers" Speakers currentPage
        menuItem "Location" Page.Location currentPage
      ]
    ]
  ]
  // Nav.nav [] [
  //   Nav.brand [] [
  //     Nav.item [] [str "FableConf 2017"]
  //   ]
  //   Nav.menu [] [
  //     Nav.start [] [

  //     ]
  //   ]
  //   Nav.right [] [

  //   ]
  // ]
  //   [ Nav.left [ ]
  //       [ h1
  //           [ ClassName "nav-item is-brand title is-4" ]
  //           [ str "FableConf 2017" ] ] ]
  //     Nav.menu [] [
  //       div [ClassName "navbar-start"]
  //     ]
  //     Nav.right [ ]
  //       [ navButtons ] ]
