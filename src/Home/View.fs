module Home.View

open Fable.Core
open Fable.Core.JsInterop
open Fable.Helpers.React
open Fable.Helpers.React.Props
open Elmish.Bulma.Elements
open Types

let root model dispatch =
  div [] [
    h1 [ClassName "title is-1"] [str "FableConf 2017"]
    h4 [ClassName "subtitle is-4"] [
      Icon.icon [Icon.isMedium] [i [ClassName "fa fa-calendar"] []]
      str " 22 September  "
      Icon.icon [Icon.isMedium] [i [ClassName "fa fa-map-marker"] []]
      str " Bordeaux, Paris"
    ]
    Image.image [] [img [Src "img/fableconf.png"]]
    div [ClassName "content"] [
      p [] [str "Come to the beautiful city of Bordeaux and be part of the first conference focused on development for the Javascript platform in F# with Fable! Fableconf will be a full day of talks by some of the main contributors to the Fable ecosystem to learn all the new possibilities the Fable compiler opens to F# programmers. And it will also be the first opportunity for the growing Fable community to meet in person, share experiences and plan together the next big project to disrupt the web."]
      p [] [str "No matter if you are new to Fable, don't have much experience in web development or even if you don't know F# yet, if you are a developer interested in writing user interfaces in a functional programming language designed for high productivity and with cutting-edge tooling, Fableconf will have something for you!"]
    ]
    div [ClassName "level"] [
      div [ClassName "level-item"] [
        a [
          ClassName "notification is-info"
          Href "https://www.eventbrite.es/e/fableconf-bordeaux-tickets-34089709238"
        ] [str "GET YOUR TICKET NOW!"]
      ]
    ]
  ]
