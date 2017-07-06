module Home.View

open Fable.Core
open Fable.Core.JsInterop
open Fable.Helpers.React
open Fable.Helpers.React.Props
open Elmish.Bulma.Elements
open Types

let root model dispatch =
  div [ClassName "container"] [
    Image.image [] [
      img [Src "img/fableconf.png"]
    ]
    // h1 [ClassName "title is-1"] [str "FableConf 2017"]
    h4 [ClassName "title is-4"] [
      Icon.icon [Icon.isMedium] [i [ClassName "fa fa-calendar"] []]
      str " 22 September  "
      Icon.icon [Icon.isMedium] [i [ClassName "fa fa-map-marker"] []]
      str " Bordeaux, France"
    ]
    h6 [ClassName "subtitle is-6"] [
      str "FableConf logo by "
      a [Href "http://paulbacchus.com/"] [str "Paul Bacchus"]
    ]
    div [ClassName "content"] [
      br []
      p [] [
        str "Come to the beautiful city of Bordeaux and be part of the first conference focused on development for the Javascript platform in F# with "
        a [Href "http://fable.io"] [str "Fable"]
        str "! FableConf will be a full day of talks by some of the main contributors to the Fable ecosystem to learn all the new possibilities the Fable compiler opens to F# programmers. And it will also be the first opportunity for the growing Fable community to meet in person, share experiences and plan together the next big project to disrupt the web."
      ]
      p [] [
        str "No matter if you are new to "
        a [Href "http://fable.io"] [str "Fable"]
        str ", don't have much experience in web development or even if you don't know F# yet, if you are a developer interested in writing user interfaces in a functional programming language designed for high productivity and with cutting-edge tooling, FableConf will have something for you!"
      ]
    ]
    div [ClassName "level"] [
      div [ClassName "level-item"] [
        a [
          ClassName "notification is-primary"
          Href "https://www.eventbrite.es/e/fableconf-bordeaux-tickets-34089709238"
        ] [str "GET YOUR TICKET NOW!"]
      ]
    ]
    h1 [ClassName "title is-1 has-text-centered"] [str "Sponsors"]
    h4 [ClassName "subtitle is-4 has-text-centered"] [str "Many thanks to our fabulous sponsors who make this conference possible!"]
    div [ClassName "level"] [
      div [ClassName "level-item"] [
        a [Href "http://fsharp.org/"] [
          Image.image [] [img [Src "img/fsharp.png"]]
        ]
      ]
    ]
  ]
