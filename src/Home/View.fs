module Home.View

open Fable.Core
open Fable.Core.JsInterop
open Fable.Helpers.React
open Fable.Helpers.React.Props
open Fulma.FontAwesome
open Fulma
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
        a [Href "https://mangelmaxime.github.io/Fable.Elmish.Bulma"] [str "Fable.Fulma"]
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

let misterySpeaker =
  h5 [ClassName "title is-5"] [
    Icon.faIcon [] [Fa.icon Fa.I.Question]
    Icon.faIcon [] [Fa.icon Fa.I.Question]
    str "Mistery Speaker"
    Icon.faIcon [] [Fa.icon Fa.I.Question]
    Icon.faIcon [] [Fa.icon Fa.I.Question]
  ]

let linkImage src href =
  a [Href href] [img [Src ("img/" + src)]]

let breakCard time text =
  h5 [ClassName "title is-5"] [str text]
  |> genericCard false time

let workshopCard time title body =
  div [ClassName "workshop"] [
    h3 [ClassName "title is-6"] [str title]
    body
  ]
  |> genericCard true time

let partyCard isTalk time body =
  div [ClassName "party"] body
  |> genericCard isTalk time

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
    div [ClassName "container"] [
      Image.image [Image.CustomClass "fableconf-logo"] [
        img [Src "img/fableconf.svg"]
      ]
      // h1 [ClassName "title is-1"] [str "FableConf 2017"]
      h4 [ClassName "title is-4"] [
        Icon.icon [Icon.Size Size.IsMedium] [i [ClassName "fa fa-calendar"] []]
        str " 26-27 October  "
        Icon.icon [Icon.Size Size.IsMedium] [i [ClassName "fa fa-map-marker"] []]
        str " Berlin, Germany"
      ]
      h6 [ClassName "subtitle is-6"] [
        str "FableConf logo by "
        a [Href "http://paulbacchus.com/"] [str "Paul Bacchus"]
      ]
      div [ClassName "content"] [
        p [] [
          str "Come to the beautiful city of Berlin and be part of the combined FableConf and RemmiDemmi F# conferences! This year FableConf and RemmiDemmi are joining forces to provide two days of F#un opportunities for learning and meeting people from the Fable and F# communities."
        ]
        p [] [
          str "We'll have two days and two tracks of sessions:"
        ]
        p [] [
          str "Day one will consist of talks on two tracks: the Fable track will provide you with the change to learn all about the latest developments on Fable, whilst the RemmiDemmi track will be our usual \"anything goes\" F# track, with relaxed discussions and sessions on cool F# tech (with a slight focus towards SAFE Stack developments)."
        ]
        p [] [
          str "Day two will be filled with practical workshops and chances to sit down and work alongside fellow members of the F# community to give you confidence in writing Fable and SAFE applications that take full advantage of F#."
        ]
        p [] [
          str "No matter if you are new to Fable or SAFE, don't have much experience in web development or even if you don't know F# yet - if you are a developer interested in writing user interfaces in a functional programming language designed for high productivity and with cutting-edge tooling, this year's FableConf and RemmiDemmi will have something for you!"
        ]
        // p [] [
        //   str "Check the Programme below, get to know our "
        //   a [Href "#speakers"] [str "wonderful speakers"]
        //   str " and feast your eyes with the "
        //   a [Href "#food"] [str "splendid menu"]
        //   str " we are preparing. The only thing that is missing is you!"
        // ]
        br []
      ]
    ]
    div [ClassName "container"] [
      h2 [ClassName "title is-2 has-text-centered"] [str "Friday: Talks"]
      p [Class "has-text-centered"] [str "More info coming soon!"]
      // div [] [ // Group so :first-child :last-child rules apply
      //   breakCard   "8:30 - 9:30"   "Breakfast"
      //   speakerCard "9:30 - 10:30"  Speakers.Types.Alfonso
      //   breakCard   "10:30 - 10:45" "Coffee Break"
      //   speakerCard "10:45 - 11:30" Speakers.Types.Eugene
      //   breakCard   "11:30 - 11:45" "Coffee Break"
      //   speakerCard "11:45 - 12:30" Speakers.Types.Maxime
      //   breakCard   "12:30 - 14:00" "Lunch"
      //   speakerCard "14:00 - 14:30" Speakers.Types.Indy
      //   breakCard   "14:30 - 14:45" "Coffee Break"
      //   speakerCard "14:45 - 15:30" Speakers.Types.Sven
      //   breakCard   "15:30 - 15:45" "Coffee Break"
      //   speakerCard "15:45 - 16:30" Speakers.Types.Krzysztof
      //   breakCard   "16:30 - 16:45" "Coffee Break"
      //   speakerCard "16:45 - 17:25" Speakers.Types.François
      //   genericCard true "17:25 - 17:30" misterySpeaker
      // ]
      // br []
      br []

      // div [ClassName "container has-text-centered"] [
      //   h2 [ClassName "title is-2"] [ //; Style [Color "#f5ec48"]] [
      //     Icon.faIcon [] [Fa.icon Fa.I.Star]
      //     Icon.faIcon [] [Fa.icon Fa.I.Star]
      //     str "Party"
      //     Icon.faIcon [] [Fa.icon Fa.I.Star]
      //     Icon.faIcon [] [Fa.icon Fa.I.Star]
      //   ]
      //   h4 [ClassName "subtitle is-6"] [
      //     str "After the talks, it is time for the "; em [] [str "Fabelous Party!"]
      //     str " Join us to keep enjoying the local gastronomy and relax chatting with other community members. "
      //     strong [] [str "Please note the conference ticket does not include the food and drinks for the party."]
      //   ]
      // ]
      // br []
      // div [] [
      //   partyCard true  "20:00 - 22:00" [
      //     str "Dinner at "
      //     a [Href "http://lejardinpecheur.com/"] [str "Le Jardin Pêcheur"]
      //     str ", a beautiful restaurant mixing modern and traditional architecture with a strong social compromise and delicious local food. "
      //     a [Href "https://docs.google.com/document/d/1AO0P7Z0Npyk62o5ZmYr9fEu1oD5pvPLUMg_ZS67GHYY/edit"] [str "Check the menu here."]
      //   ]
      //   partyCard false "22:00 - ???" [
      //     str "Drinks at "
      //     a [Href "http://lezytho.fr/"] [str "Le Zytho"]
      //     str ": (Re)discover the Craft Beer with a selection of 18 draught and 100 bottled beers!"
      //   ]
      // ]
      // br []
      // br []

      h2 [ClassName "title is-2 has-text-centered"] [str "Saturday: Workshops"]
      p [Class "has-text-centered"] [str "More info coming soon!"]
      // div [] [ // Group so :first-child :last-child rules apply
      //   workshopCard  "9:00 - 10:45" Workshops.aTitle Workshops.aBody
      //   breakCard    "10:45 - 11:00" "Break"
      //   workshopCard "11:00 - 12:45" Workshops.bTitle Workshops.bBody
      //   breakCard    "12:45 - 14:00" "Break"
      //   workshopCard "14:00 - 15:45" Workshops.cTitle Workshops.cBody
      //   breakCard    "15:45 - 16:00" "Break"
      //   workshopCard "16:00 - 17:45" Workshops.dTitle Workshops.dBody
      // ]
      br []

      // article [ClassName "message is-primary"] [
      //   div [ClassName "message-body has-text-centered"] [
      //     p [] [
      //       str "Workshops will take place at "
      //       a [Href "https://www.google.fr/maps/place/Bordeaux+Digital+Campus/@44.863924,-0.5613694,16z/data=!4m5!3m4!1s0xd54d9a55ce015bf:0xd2da001c64f8dddc!8m2!3d44.863924!4d-0.556992"] [str "Bordeaux Digital Campus"]
      //       str ", five minutes walking from "
      //       a [Href "#location"] [str "Cap Sciences"]
      //       str "."
      //     ]
      //     p [] [
      //       str "Check your system meets "
      //       a [Href "http://fable.io/docs/getting-started.html#requirements"] [str "the requirements"]
      //       str " to run Fable."
      //     ]
      //     p [] [str "Please note food won't be provided on Saturday."]
      //   ]
      // ]
    ]
    br []
    section [
      ClassName "hero is-medium is-primary"
      ] [
        div [ClassName "hero-body"] [
          div [ClassName "container"] [
            a [Href "https://www.eventbrite.co.uk/e/fableconf-2018-remmidemmi-in-the-safe-house-tickets-47025731228"] [
              h1 [ClassName "title is-1 has-text-centered"] [str  "GET YOUR TICKET NOW!"]
            ]
          ]
        ]
      ]
    br []
    h1 [ClassName "title is-1 has-text-centered"] [str "Sponsors"]
    h4 [ClassName "subtitle is-4 has-text-centered"] [str "Many thanks to our fabulous sponsors who make this conference possible!"]
    div [ClassName "flex-wrap sponsors"] [
      linkImage "fsharp.png" "http://fsharp.org/"
      linkImage "compositional-it.png" "https://compositional-it.com/"
      linkImage "microsoft.png" "https://www.microsoft.com/"
      // linkImage "nsynk2.png" "http://nsynk.de/"
      // linkImage "syrpin.jpg" "http://www.syrpin.org/"
      // linkImage "digital-campus.png" "https://www.digital-campus.fr/"
      // linkImage "BxGames.png" "http://bordeauxgames.com/"
      // linkImage "cap-sciences2.jpg" "http://www.cap-sciences.net/"
    ]
    br []
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
              img [
                Style [Margin "0 auto"; Width "auto"]
                Src "img/diversity.png"]
            ]
          ]
        ]
      ]
    ]
  ]
