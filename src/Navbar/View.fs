module Navbar.View

open Fable.Helpers.React
open Fable.Helpers.React.Props
open Elmish.Bulma.Components
open Elmish.Bulma.Elements.Form

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

let root =
  Nav.nav
    [ ]
    [ Nav.left [ ]
        [ h1
            [ ClassName "nav-item is-brand title is-4" ]
            [ str "FableConf 2017" ] ]
      Nav.right [ ]
        [ navButtons ] ]
