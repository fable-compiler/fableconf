module Speakers.State

open Elmish
open Types

let init () : Model * Cmd<Msg> =
  { modal = None }, []

let update msg model =
  match msg with
  | OpenModal(speaker, talk) -> { modal = Some(speaker, talk) }, []
  | CloseModal -> { modal = None }, []
