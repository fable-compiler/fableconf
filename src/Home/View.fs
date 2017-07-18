module Home.View

open Fable.Core
open Fable.Core.JsInterop
open Fable.Helpers.React
open Fable.Helpers.React.Props
open Elmish.Bulma.Elements
open Types

let genericCard isTalk time body =
  let typ = if isTalk then "talk" else "break"
  div [ClassName "columns schedule"] [
    div [ClassName ("column is-one-quarter schedule-time schedule-" + typ)] [
      h5 [ClassName "title is-5"] [strong [] [str time]]
    ]
    div [ClassName ("column schedule-content schedule-" + typ)] [
      body
    ]
  ]

let breakCard time text =
  a [Href "#food"; ClassName "title is-5"] [str text]
  |> genericCard false time

let workshopCard time text =
  h5 [ClassName "title is-5"] [str text]
  |> genericCard true time

let speakerCard time (speaker: Speakers.Types.Speaker) =
  div [ClassName "columns schedule"] [
    div [ClassName "column is-one-quarter schedule-time schedule-talk"] [
      h5 [ClassName "title is-5"] [strong [] [str time]]
    ]
    div [ClassName "column schedule-content schedule-talk"] [
      article [ClassName "media"] [
        figure [ClassName "media-left"] [
          p [ClassName "image is-64x64"] [
            img [Src speaker.picture]
          ]
        ]
        figure [ClassName "media-content"] [
          div [ClassName "content"] [
            a [Href ("#speakers/" + speaker.shortname)] [
              strong [] [str speaker.name]
              br []
              str speaker.talk.title
            ]
          ]
        ]
      ]
    ]
  ]

let root model dispatch =
  div [] [
    Image.image [] [
      img [Src "img/fableconf.svg"]
    ]
    div [ClassName "container"] [
      // h1 [ClassName "title is-1"] [str "FableConf 2017"]
      h4 [ClassName "title is-4"] [
        Icon.icon [Icon.isMedium] [i [ClassName "fa fa-calendar"] []]
        str " 22-23 September  "
        Icon.icon [Icon.isMedium] [i [ClassName "fa fa-map-marker"] []]
        str " Bordeaux, France"
      ]
      h6 [ClassName "subtitle is-6"] [
        str "FableConf logo by "
        a [Href "http://paulbacchus.com/"] [str "Paul Bacchus"]
      ]
      div [ClassName "content"] [
        p [] [
          str "Come to the beautiful city of Bordeaux and be part of the first conference focused on development for the Javascript platform in F# with "
          a [Href "http://fable.io"] [str "Fable"]
          str "! Fableconf will take two full days: one day of talks to learn all new possibilities Fable opens to F# programmers, and another day of workshops to put everything into practice. FableConf will also be the first opportunity for the growing Fable community to meet in person, share experiences and plan together the next big project to disrupt the web."
        ]
        p [] [
          str "No matter if you are new to "
          a [Href "http://fable.io"] [str "Fable"]
          str ", don't have much experience in web development or even if you don't know F# yet, if you are a developer interested in writing user interfaces in a functional programming language designed for high productivity and with cutting-edge tooling, FableConf will have something for you!"
        ]
        p [] [
          str "Check the Programme below, get to know our "
          a [Href "#speakers"] [str "wonderful speakers"]
          str " and feast your eyes with the "
          a [Href "#food"] [str "splendid menu"]
          str " we are preparing. The only thing that is missing is you!"
        ]
        br []
      ]
    ]
    div [ClassName "container"] [
      h2 [ClassName "title is-2 has-text-centered"] [str "Friday"]
      breakCard   "8:30 - 9:30" "Breakfast"
      speakerCard "9:30 - 10:30" Speakers.Types.Alfonso
      breakCard   "10:30 - 10:45" "Break"
      speakerCard "10:45 - 11:30" Speakers.Types.Eugene
      breakCard   "11:30 - 11:45" "Break"
      speakerCard "11:45 - 12:30" Speakers.Types.François
      breakCard   "12:30 - 14:00" "Lunch"
      speakerCard "14:00 - 14:15" Speakers.Types.Karsten
      speakerCard "14:15 - 15:00" Speakers.Types.Krzysztof
      breakCard   "15:00 - 15:15" "Break"
      speakerCard "15:15 - 15:30" Speakers.Types.Maxime
      speakerCard "15:30 - 16:15" Speakers.Types.Sven
      breakCard   "16:15 - 16:30" "Break"
      breakCard   "16:30 - 16:45" "Lightning talk: TBA"
      speakerCard "16:45 - 17:30" Speakers.Types.Indy

      h2 [ClassName "title is-2 has-text-centered"] [str "Saturday"]
      workshopCard "9:00 - 13:00" "Workshops"
      genericCard  false "13:00 - 14:00"
        (h5 [ClassName "title is-5"] [str "Break"])
      workshopCard "14:00 - 18:00" "Workshops"

      article [ClassName "message is-primary"] [
        div [ClassName "message-body has-text-centered"] [
          str "More details about the workshops will be uploaded soon. Please note "
          strong [] [str "food is not provided on Saturday"]
          str "."
        ]
      ]
    ]
    br []
    section [
      ClassName "hero is-medium is-primary"
      ] [
        div [ClassName "hero-body"] [
          div [ClassName "container"] [
            a [Href "https://www.eventbrite.es/e/fableconf-bordeaux-tickets-34089709238"] [
              h1 [ClassName "title is-1 has-text-centered"] [str  "GET YOUR TICKET NOW!"]
            ]
          ]
        ]
      ]
    br []
    h1 [ClassName "title is-1 has-text-centered"] [str "Sponsors"]
    h4 [ClassName "subtitle is-4 has-text-centered"] [str "Many thanks to our fabulous sponsors who make this conference possible!"]
    div [ClassName "level"] [
      div [ClassName "level-item"] [
        a [Href "http://fsharp.org/"] [
          Image.image [] [img [Src "img/fsharp.png"]]
        ]
      ]
    ]
    div [ClassName "container"] [
      div [ClassName "columns"] [
        div [ClassName "column is-three-quarters"] [
          h3 [ClassName "title is-3"] [str "CODE OF CONDUCT"]
          h4 [ClassName "subtitle is-4"] [str "Be respectful, be open, and be considerate."]
          p [] [
            str "Our conference is dedicated to providing a harassment-free conference experience for everyone, regardless of gender, gender identity and expression, age, sexual orientation, disability, physical appearance, body size, race, or religion (or lack thereof). We do not tolerate harassment of conference participants in any form. Sexual language and imagery is not appropriate for any conference venue, including talks, workshops, parties, Twitter and other online media. Conference participants violating these rules may be sanctioned or expelled from the conference without a refund at the discretion of the conference organisers. "
            a [Href "http://confcodeofconduct.com/"] [str "Read more."]
          ]
        ]
        div [ClassName "column"] [
          a [Href "http://diversitycharter.org/"] [
            figure [ClassName "image"] [
              img [Src "img/diversity.png"]
            ]
          ]
        ]
      ]
    ]
  ]
