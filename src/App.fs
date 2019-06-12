module App

open Fable.Core
open Router

[<Emit("encodeURI($0)")>]
let encodeURI (r: string): string = jsNative

module Types =

  type ActivePage =
    | Home of Page.Home.Types.Model
    | Agenda of Page.Agenda.Types.Model

  type Msg =
    | HomeMsg of Page.Home.Types.Msg
    | AgendaMsg of Page.Agenda.Types.Msg
    | NavbarMsg of Page.Navbar.Types.Msg

  type Model =
    {
      ActivePage:ActivePage option
      Navbar:Page.Navbar.Types.Model
      CurrentRoute:Route option
      IsLoading:bool
    }

module State =

  open Types
  open Elmish
  open Elmish.Navigation
  open Elmish.UrlParser

  module Update =

    let load model =
      {model with IsLoading=true}

    let loadFinished model =
      {model with IsLoading=false}

    let activePage activePage route model =
      {
        model with
          IsLoading=false
          ActivePage=Some activePage
      },Router.modifyUrl route

    let routeMessage activePage mapper command model =
      { model with ActivePage=Some activePage}, Cmd.map mapper command

  let rec setRoute (optRoute: Option<Route>) model =
      let model = { model with CurrentRoute = optRoute }
      match optRoute with
        | Some ( Route.Home ) ->
          model
            |> Update.activePage
              (ActivePage.Home (Page.Home.Types.initialModel))
              Route.Home

        | Some Route.Agenda -> // TODO
          model
            |> Update.activePage
              (ActivePage.Agenda (Page.Agenda.Types.initialModel))
              Route.Agenda

        | None ->
          model |> setRoute( Some (Route.Home))

  let init location : Model * Cmd<Msg> =

    let (model, cmd) =
      setRoute location
        {
          ActivePage=None
          CurrentRoute=None
          IsLoading=false
          Navbar=Page.Navbar.State.init ()
        }

    model, cmd

  let nextPage route model =
    setRoute (Some route) model

  let update msg model =
      match model.ActivePage, msg with
      | _, NavbarMsg msg ->
        match msg with
        | Page.Navbar.Types.Back ->
          model
            |> Update.load
            |> nextPage Route.Home //Sensors

        | _ ->
          let updated, cmd = Page.Navbar.State.update msg model.Navbar
          { model with Navbar = updated}, Cmd.map NavbarMsg cmd

      | Some page, msg ->
        match page,msg with
        | Home md, HomeMsg msg ->
          match msg with
          | _ ->
              let updated, cmd = Page.Home.State.update msg md
              model
                |> Update.routeMessage (ActivePage.Home updated) HomeMsg cmd

        | Agenda md, AgendaMsg msg ->
          match msg with
          | _ ->
              let updated, cmd = Page.Agenda.State.update msg md
              model
                |> Update.routeMessage (ActivePage.Agenda updated) AgendaMsg cmd

        | _ ->
          model, Cmd.none

      | _ ->
        model, Cmd.none

module View =

  open Types
  open Fable.React

  let root (model:Model) dispatch =

    match model.ActivePage with
    | Some page ->
      match page with
      | (ActivePage.Home md) ->
          fragment [] [
              Page.Navbar.View.root Route.Home model.Navbar (NavbarMsg >> dispatch)
              Page.Home.View.root md (HomeMsg >> dispatch)
          ]

      | (ActivePage.Agenda md) ->
          fragment [] [
              Page.Navbar.View.root Route.Agenda model.Navbar (NavbarMsg >> dispatch)
              Page.Agenda.View.root md (AgendaMsg >> dispatch)
          ]

    | None ->
      div [] [str "No active page!"]

open Elmish
open Elmish.Navigation
open Elmish.UrlParser
open Elmish.React
open Elmish.Debug
open Elmish.HMR

Program.mkProgram State.init State.update View.root
  |> Program.toNavigable (parseHash Router.pageParser) State.setRoute
  |> Program.withReactSynchronous "elmish-app"
#if DEBUG
  |> Program.withConsoleTrace
#endif
  |> Program.run
