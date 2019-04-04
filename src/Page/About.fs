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
          div [] [
            div [
              ClassName "ftitle"
            ] [
              Heading.h1 [] [
                  span [ ClassName "top" ] [ str "FABLE" ]
                  br []
                  span [ ClassName "bottom" ] [ str "CONF'19" ]
              ]
              div [
                ClassName "dates"
              ] [
                  span [ ClassName "date"] [ str "6/7 sept 2019" ]
                  br []
                  span [ ClassName "date"] [ 
                    strong [] [str "Antwerp" ]
                    str ", Belgium" ]
              ]
              //hr []
              div [ 
                ClassName "axxesLogo"
              ] [ 
                span [] [ strong [] [ str "Powered by"]]
                img [
                  Src "./logo.png"
                ] 
              ]
            ]
          ]
        ]
      ]
