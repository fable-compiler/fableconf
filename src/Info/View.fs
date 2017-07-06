module Info.View

open Fable.Helpers.React
open Fable.Helpers.React.Props
open Fable.Core.JsInterop
open Elmish.Bulma.Elements

let root =
  div [] [
    section [
      ClassName "hero is-medium is-primary"
      Style [
        BackgroundImage "url(img/cap-sciences.jpg)"
        BackgroundRepeat "no-repeat"
        !!("backgroundSize", "cover")
        !!("backgroundPositionY", "-100px")
      ]
    ] [
      div [ClassName "hero-body"] [
        div [ClassName "container"] [
          h1 [ClassName "title"] [str "Cap Sciences"]
          h2 [ClassName "subtitle"] [str "Bordeaux, France"]
        ]
      ]
    ]
    // Image.image [] [img [Src "img/cap-sciences.jpg"]]
    // br []
    // h3 [ClassName "title is-3"] [str "Cap Sciences"]
    // h5 [ClassName "subtitle is-5"] [str "Bordeaux, France"]
    div [ClassName "container"] [
      div [ClassName "content"] [
        br []
        p [] [
          str "FableConf will take place in the impressive "
          a [Href "http://www.cap-sciences.net/"] [str "Cap Sciences"]
          str ", a reformed hangar on the quays of Bordeaux whose mission is to make Science accesible to all publics."
        ]
        p [] [str "Bordeaux is a splendid city and a popular touristic destination. Make the most of your trip and relax during the weekend enjoying its restaurants, cafés and world-famous wineries, among many other attractions."]
        br []
      ]
    ]
    iframe [
      Src "https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d5656.240080660091!2d-0.5584963664357877!3d44.85985097909837!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0xd55288fe041f36f%3A0xc849cfd5c16a7bb8!2sCap+Sciences!5e0!3m2!1sen!2ses!4v1499327326158"
      Style [Border 0; Height 450; CSSProp.Width "100%"]
      AllowFullScreen true
    ] []
  ]
