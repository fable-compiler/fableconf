module Home.View

open Fable.Core
open Fable.Core.JsInterop
open Fable.Helpers.React
open Fable.Helpers.React.Props
open Fulma.Elements
open Types

module Workshops =
  let aTitle = "Developing web apps with Elmish"
  let aBody =
    div [] [
      p [] [
        str "Thanks to the model-view-update architecture you can easily create a web app without any mutable state messing around. But even if you do need to get your hands dirty to interact with external components, you will learn how Elmish allows you do that without a hassle."
      ]
      p [] [
        str "In this workshop you will be also introduced to an Elmish extension that makes dealing with CSS a much more pleasant task: "
        a [Href "https://mangelmaxime.github.io/Fable.Fulma/#elements/button"] [str "Fable.Fulma"]
      ]
    ]

  let bTitle = "Data visualization on-the-fly"
  let bBody =
    div [] [
      p [] [
        str "From its very beginning, F# has been a great language for exploring data, even more so thanks to tools like "
        a [Href "https://fslab.org/"] [str "FsLab"]
        str ". However the solution to visualize the results has not been always ideal: sometimes it was Windows-only and other times was a bit cumbersome and slow."
      ]
      p [] [
        str "Luckily, Fable now brings the whole power of browser graphics to F#. In this workshop you'll learn how to combine .NET F# for data manipulation with JS F# for instantaneous representation in a way that can be later easily embedded in a web while keeping your graphics interactive."
      ]
    ]

  let cTitle = "Write your own VS Code extension"
  let cBody =
    div [] [
      a [Href "#speakers/krzysztof"] [str "Krzysztof Cieślak"]
      str ", "
      a [Href "http://ionide.io/"] [str "Ionide"]
      str " author and one of the most veteran Fable users, will show us how easy is to use the power and expressiveness of F# to create extensions for Visual Studio Code, automate common tasks and increase your productivity."
    ]

  let dTitle = "Make a simple (but addictive!) game"
  let dBody =
    div [] [
      p [] [
        str "It's time for some fun! Let's close FableConf with a game. We will use the same Elmish architecture as for web apps, in order to reuse our knowledge and tools like the time-travel debugger, but with a different renderer: "
        a [Href "http://www.pixijs.com/"] [str "PixiJS"]
      ]
      p [] [
        str "You will also learn some techniques to improve performance and make your games run smoothly on any device, like object pooling or background computations with a web worker."
      ]
    ]

let genericCard isTalk time body =
  let typ = if isTalk then "talk" else "break"
  div [ClassName "columns schedule"] [
    div [ClassName ("column is-one-quarter schedule-time schedule-" + typ)] [
      p [ClassName "title is-5"] [str time]
    ]
    div [ClassName ("column schedule-content schedule-" + typ)] [
      body
    ]
  ]

let breakCard time text =
  h5 [ClassName "title is-5"] [str text]
  |> genericCard false time

let workshopCard time title body =
  div [ClassName "workshop"] [
    h3 [ClassName "title is-6"] [str title]
    body
  ]
  |> genericCard true time

let speakerCard time (speaker: Speakers.Types.Speaker) =
  div [ClassName "columns schedule"] [
    div [ClassName "column is-one-quarter schedule-time schedule-talk"] [
      p [ClassName "title is-5"] [str time]
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
  div [Style [!!("overflowY", "hidden")]] [
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
      h2 [ClassName "title is-2 has-text-centered"] [str "Friday: Talks"]
      div [] [ // Group so :first-child :last-child rules apply
        breakCard   "8:30 - 9:30"   "Breakfast"
        speakerCard "9:30 - 10:30"  Speakers.Types.Alfonso
        breakCard   "10:30 - 10:45" "Coffee Break"
        speakerCard "10:45 - 11:30" Speakers.Types.Eugene
        breakCard   "11:30 - 11:45" "Coffee Break"
        speakerCard "11:45 - 12:30" Speakers.Types.François
        breakCard   "12:30 - 14:00" "Lunch"
        speakerCard "14:00 - 14:15" Speakers.Types.Karsten
        speakerCard "14:15 - 15:00" Speakers.Types.Krzysztof
        breakCard   "15:00 - 15:15" "Coffee Break"
        speakerCard "15:15 - 15:30" Speakers.Types.Maxime
        speakerCard "15:30 - 16:15" Speakers.Types.Sven
        breakCard   "16:15 - 16:30" "Coffee Break"
        breakCard   "16:30 - 16:45" "Lightning talk: TBA"
        speakerCard "16:45 - 17:30" Speakers.Types.Indy
      ]
      br []
      br []

      h2 [ClassName "title is-2 has-text-centered"] [str "Saturday: Workshops"]
      div [] [ // Group so :first-child :last-child rules apply
        workshopCard "9:00 - 10:50"  Workshops.aTitle Workshops.aBody
        breakCard    "10:50 - 11:10" "Break"
        workshopCard "11:10 - 13:00" Workshops.bTitle Workshops.bBody
        breakCard    "13:00 - 14:00" "Break"
        workshopCard "14:00 - 15:50" Workshops.cTitle Workshops.cBody
        breakCard    "15:50 - 16:10" "Break"
        workshopCard "16:10 - 18:00" Workshops.dTitle Workshops.dBody
      ]
      br []

      article [ClassName "message is-primary"] [
        div [ClassName "message-body has-text-centered"] [
          p [] [
            str "Workshops will take place at "
            a [Href "http://www.coolworking.fr/"] [str "Coolworking"]
            str ". Please check your system meets "
            a [Href "http://fable.io/pages/prerequisites.html"] [str "the requirements"]
            str " to run Fable."
          ]
          p [] [str "Seats are limited so there's a possibility not everybody can attend all the workshops. Thanks for your understanding."]
          p [] [str "Please note food won't be provided on Saturday."]
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
      div [ClassName "level-item"] [
        a [Href "http://nsynk.de/"] [
          Image.image [] [img [Src "img/nsynk2.png"]]
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
