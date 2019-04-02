namespace Page

module About = 

  module Types = 

    type Model = int
    type Msg = | DoSomething

    let initialModel = 0
  
  module State = 

    open Types
    open Elmish
    
    let update msg model = 
      match msg with 
      | DoSomething -> model, Cmd.none

  module View = 

    open Types
    open Fulma
    open Fable.Core.JsInterop
    open Fable.Helpers.React
    open Fable.Helpers.React.Props

    let root model dispatch = 
      div [] [ str "welcome" ]
