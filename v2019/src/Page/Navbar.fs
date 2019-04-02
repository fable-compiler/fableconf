namespace Page.Navbar

module Types =

  open Types 

  type Msg =
    | Disconnect
    | ShowChangeLog
    | DoSomething
    | Back
    | ToggleBurger

  type Model = {
    IsBurgerOpen : bool
  }

module State = 

  open Elmish
  open Types

  let init() : Model = { IsBurgerOpen=false }

  let update msg model : Model * Cmd<Msg> =
    match msg with
    | ToggleBurger ->
      { model with IsBurgerOpen = not model.IsBurgerOpen }, Cmd.none

    | _ ->
      model, Cmd.none


module View =

  open Fulma
  open Fable.Helpers.React
  open Fable.Helpers.React.Props
  open Fable.Import.React
  open Fable.FontAwesome

  open Types

  let root model dispatch  =

    Navbar.navbar [ 
      Navbar.HasShadow
      Navbar.Color IsDark
    ] 
      [
        Navbar.Brand.div [] [
          str ""
        ]
        Navbar.menu
          [ 
            Fulma.Navbar.Menu.IsActive model.IsBurgerOpen 
          ]
          [ Navbar.Start.div[] [str "" ] ]
      ]
