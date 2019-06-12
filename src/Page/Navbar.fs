namespace Page.Navbar

module Types =

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

    open Fable.React
    open Fable.React.Props
    open Router
    open Types

    let navButton classy href faClass =
      a [ Href href
          Target "_blank" ]
        [ span
            [ Class "icon" ]
            [ i
                [ Class (sprintf "navbar-social-icon %s" faClass) ]
                [ ] ]
        ]

    let navButtons =
      [
        div [Class "navbar-item navbar-social"]
              [ navButton "twitter" "https://twitter.com/FableCompiler" "fab fa-twitter" ]
        div [Class "navbar-item navbar-social"] [
                navButton "gitter" "https://gitter.im/fable-compiler/Fable" "fas fa-comment-dots" ]
      ]

    let menuItem label page currentPage dispatch=
        a [
          classList ["navbar-item", true; "is-active", page = currentPage]
          Href (toHash page)
          OnClick (fun _ -> dispatch ToggleBurger)
        ] [str label]

    let root currentPage (model: Model) dispatch =
      nav [Class "navbar"] [
        div [Class "navbar-brand"] [
          div [
            classList ["navbar-burger", true
                       "is-active", model.IsBurgerOpen]
            OnClick (fun _ -> dispatch ToggleBurger)
          ] [
            span [] []
            span [] []
            span [] []
          ]
        ]
        div [classList ["navbar-menu", true; "is-active", model.IsBurgerOpen]] [
          div [Class "navbar-start"] [
            div [Class "navbar-item navbar-logo"] [
              a [Href (toHash Route.Home)] [h1 [] [str "FABLECONF'19"] ]
            ]
            menuItem "Home" Route.Home currentPage dispatch
            menuItem "Agenda" Route.Agenda currentPage dispatch
          ]
          div [Class "navbar-end"] navButtons
        ]
      ]
