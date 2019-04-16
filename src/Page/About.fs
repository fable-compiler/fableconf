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

    let pic = 
        Hero.hero [ 
          Hero.IsLarge
          Hero.Props [
            Style [
              BackgroundImage """url("./mas.jpg")"""
              BackgroundRepeat "no-repeat"
              BackgroundPosition "center center"
              BackgroundSize "cover"
              BackgroundColor "#fff"
              Height "200px"
            ]
          ]
        
        ] [ 
          div [ ClassName "picCredits"] [ str "Picture credits: PanaTomix CC-BY-NC 2.0 0b" ]          
        ]

    let cover = 
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
                span [] [ strong [] [ str "Powered by "]]
                a [ Href "https://axxes.com/"; Target "_blank" ] [
                  img [
                    Src "./logo.png"
                  ] 
                ]
              ]
            ]
          ]
        ]

    let about = 
        Hero.hero [ 
          Hero.IsMedium
          Hero.Props [
            Id "about"
          ]
        
        ] [
          Hero.body [] [
            Content.content [] [
              p[] [strong [] [str "Come to the beautiful city of Antwerp and be part of the FABLECONF conferences! This year again FABLECONF will provide two days of F# and Javascript opportunities for learning and meeting people frome the Fable community." ]]
              h2[ ] [str "Friday: talks"]
              h4[ ] [str "Ankerrui 9, 2000 Antwerpen"]
              p [][str "Day one will consists of talks. "; i[][ str "(More information to come soon...)"]]
              h2[ ] [str "Saturday: workshops"]
              h4[ ] [str "Entrepotkaai 10A, 2000 Antwerpen"]
              p [][str "Day two will be filled with practical workshops and chances to sit down and works alongside members of the F# community to give confidence in writing Fable applications that take full advantage of F# and Javascript."]
              h2[ ] [str "F# enlightenment"]
              p[] [ str "No matter if you're new to Fable, don't have much experience in front or server development or even if you don't know F# yet. If you're a developer interested in writing code using a functional programming language designed for hogh productivity and with cutting-edge tooling, this year's FABLECONF will have something for you!"]
            ]
          ]
        ]

    let footer =
      let cesure = 
          Level.item [ Level.Item.Modifiers [ Modifier.IsHiddenOnly (Screen.Mobile, true)]] [ str "|"]
        
      Footer.footer[ Props [ Id "footer"] ][
        Level.level [
        ] [
          Level.item [] [ 
            a [ Href "#"] [ strong [] [str "CODE OF CONDUCT"]]
          ]
          cesure
          Level.item [] [ 
            span [] [ 
              str "web design by "
              a [ Href "https://biensurgraphisme.com"; Target "_blank"] [ strong [] [str " Biensür Graphisme"] ]
            ]
          ]
          cesure
          Level.item [] [
            span [] [
              str "FABLE CONF is organised by Fable lovers. Powered this year by "
              a [ Href "https://axxes.com/"; Target "_blank"] [ str " AXXES!"]
            ]
          ]
        ]
      ]

    let root model dispatch = 
      div [] [
        cover
        about
        pic
        footer
      ]
