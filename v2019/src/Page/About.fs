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
      div [] [
        Hero.hero [ 
          Hero.IsFullHeight
          Hero.Props [
            Style [
              BackgroundImage """url("./landing.jpg")"""
              BackgroundRepeat "no-repeat"
              BackgroundPosition "center center"
              BackgroundSize "cover"
              BackgroundColor "#fff"
            ]
          ]
        
        ] [
          Hero.body [
          ] [
            str ""
          ]
        ]
        Hero.hero [ 
          Hero.IsFullHeight
          Hero.Props [
            Style [
              BackgroundColor "#000"
            ]
          ]
        ] [
          Hero.body [
          ] [
            str "pouet2"
          ]
        ]
      ]
