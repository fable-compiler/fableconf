module Navbar.State

open Elmish
open Types

let init () : Model * Cmd<Msg> =
  { isBurgerOpen = false }, []

let update msg model =
  match msg with
  | ToggleBurger -> { isBurgerOpen = not model.isBurgerOpen }, []
