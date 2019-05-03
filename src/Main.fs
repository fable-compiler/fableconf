module Main
open Fable.Core
open Fable.Core.JsInterop

[<Emit("encodeURI($0)")>]          
let encodeURI (r: string): string = jsNative

module Types = 

  open Types

  type ActivePage =
    | About of Page.About.Types.Model    

  type Msg = 
    | AboutMsg of Page.About.Types.Msg
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
        | Some ( Route.About )->
          model
            |> Update.activePage
              (ActivePage.About (Page.About.Types.initialModel))
              Route.About

        | None -> 
          model |> setRoute( Some (Route.About))
        
  let init location : Model * Cmd<Msg> = 
    
    printfn "***FABLECONF! OMG!***" 

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
            |> nextPage Route.About //Sensors

        | _ -> 
          let updated, cmd = Page.Navbar.State.update msg model.Navbar
          { model with Navbar = updated}, Cmd.map NavbarMsg cmd

      | Some page, msg ->
        match page,msg with      
        | About md, AboutMsg msg -> 
          match msg with 
          | _ -> 
              let updated, cmd = Page.About.State.update msg md
              model
                |> Update.routeMessage (ActivePage.About updated) AboutMsg cmd        

        | _ -> 
          model, Cmd.none

      | _ -> 
        model, Cmd.none

module View = 

  open Types
  open Fulma
  open Fable.Core.JsInterop
  open Fable.React
  open Fable.React.Props
  
  let root (model:Model) dispatch = 

    let publicView (model:Model) dispatch view =
        view

    match model.ActivePage with 
    | Some page -> 
      match page with 
      | (ActivePage.About md) -> 
          Page.About.View.root md (AboutMsg >> dispatch)
            |> publicView model dispatch

    | None -> 
      div [] [str "No active page!"]
