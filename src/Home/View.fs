module Home.View

open Fable.Core
open Fable.Core.JsInterop
open Fable.Helpers.React
open Fable.Helpers.React.Props
open Fulma.FontAwesome
open Fulma
open Global

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
  div [Class "columns schedule"] [
    div [Class ("column is-one-quarter schedule-time schedule-" + typ)] [
      p [Class "title is-5"] [str time]
    ]
    div [Class ("column schedule-content schedule-" + typ)] [
      body
    ]
  ]

let misterySpeaker =
  h5 [Class "title is-5"] [
    Icon.faIcon [] [Fa.icon Fa.I.Question]
    Icon.faIcon [] [Fa.icon Fa.I.Question]
    str "Mistery Speaker"
    Icon.faIcon [] [Fa.icon Fa.I.Question]
    Icon.faIcon [] [Fa.icon Fa.I.Question]
  ]

let linkImage size css src href =
  div[ Class (sprintf "column %s is-vertical-center" size)] [
    Image.image [Image.CustomClass (sprintf "sponsor-image %s" css)] [
      a [Href href] [img [Src ("img/" + src)]] ]
  ]

let breakCard time text =
  h5 [Class "title is-5"] [str text]
  |> genericCard false time

let workshopCard time title body =
  div [Class "workshop"] [
    h3 [Class "title is-6"] [str title]
    body
  ]
  |> genericCard true time

let partyCard isTalk time body =
  div [Class "party"] body
  |> genericCard isTalk time

let speakerCard time (speaker: Speaker) =
  div [Class "columns schedule"] [
    div [Class "column is-one-quarter schedule-time schedule-talk"] [
      p [Class "title is-5"] [str time]
    ]
    div [Class "column schedule-content schedule-talk"] [
      article [Class "media"] [
        figure [Class "media-left"] [
          p [Class "image is-64x64"] [
            img [Src speaker.picture]
          ]
        ]
        figure [Class "media-content"] [
          div [Class "content"] [
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
  div [Id "home-page"; Style [!!("overflowY", "hidden")]] [
    div [Class "container"] [

      div[ Class "logo"] [
        Image.image [Image.CustomClass "fableconf-logo"] [
          img [Src "img/fablelogo.svg"] // this is in low res for now
        ]

        Image.image [Image.CustomClass "remmidemmi"] [
          img [Src "img/logo_Remmidemmi landing.png"] // this is in low res for now
        ]

        Image.image [Image.CustomClass "conf2018"] [
          img [Src "img/conf2018.svg"] // this is in low res for now
        ]
      ]

      // h1 [Class "title is-1"] [str "FableConf 2017"]
      div[Class "general-info"] [
        div[ Class "info" ] [
          h4 [Class "title is-4 title-bold"] [
            str "26-27 October 2018" ]
          h4 [Class "title is-4 title-light last"] [
            str "Berlin, Germany"
          ]
        ]
        div[ Class "fsharp"] [
          h4 [Class "title is-4 title-light"] [
            str "F# enlightenment" ]
      ]]

      div [Class "content standard-margin"] [
        p [] [
          str "Come to the beautiful city of Berlin and be part of the combined FableConf and RemmiDemmi F# conferences! This year FableConf and RemmiDemmi are joining forces to provide two days of F#un opportunities for learning and meeting people from the Fable and F# communities."
        ]
        p [] [
          str "We'll have two days and two tracks of sessions:"
        ]
      ]
      div[Class "general-info"] [
        div[ Class "info" ] [
          h4 [Class "title is-4 title-light"] [
            str "Friday: Talks" ]
        ]
      ]
      div [Class "content standard-margin"] [
        p [] [
          str "Day one will consist of talks on two tracks: the Fable track will provide you with the chance to learn all about the latest developments on Fable, whilst the RemmiDemmi track will be our usual \"anything goes\" F# track, with relaxed discussions and sessions on cool F# tech (with a slight focus towards SAFE Stack developments)."
        ]
      ]
      div[Class "general-info"] [
        div[ Class "info" ] [
          h4 [Class "title is-4 title-light"] [
            str "Saturday: Workshops" ]
        ]
      ]
      div [Class "content standard-margin"] [
        p [] [
          str "Day two will be filled with practical workshops and chances to sit down and work alongside fellow members of the F# community to give you confidence in writing Fable and SAFE applications that take full advantage of F#."
        ]
        p [] [
          str "No matter if you are new to Fable or SAFE, don't have much experience in web development or even if you don't know F# yet - if you are a developer interested in writing user interfaces in a functional programming language designed for high productivity and with cutting-edge tooling, this year's FableConf and RemmiDemmi will have something for you!"
        ]
        br []
        p [Class "has-text-centered"] [ str "More details can be found in the "; a [Href "#planning"] [str "agenda" ]]
      ]
    ]
    br []
    section [Class "hero is-small"] [
        div [Class "hero-body"] [
          div [Class "container"] [
            div[ Class "ticket"] [
               a [Href "https://www.eventbrite.co.uk/e/fableconf-2018-remmidemmi-in-the-safe-house-tickets-47025731228"] [
                h1 [Class "title is-1 has-text-centered"] [
                  span [] [ str  "GET YOUR "]
                  span [ Class "parisienne"] [ str  "Ticket "]
                  span [] [ str  "NOW!"]
                  ]
              ]
            ]
          ]
        ]
      ]
    br []
    section [Class "hero is-small"] [
        div [Class "hero-body"] [
          div[ Class "standard-margin"] [
            h1 [Class "title is-2 title-bold"] [str "PRE-CONFERENCE."]
            h2 [Class "title is-3"] [str "CLOUD PROGRAMMING WITH F#"]
            h4 [Class "subtitle is-5 neon-green"] [
              str "The day before FableConf, learn how to write and host "
              a [Href "https://safe-stack.github.io/"] [str "SAFE"]
              str " apps on Azure with F# - available at a special low price! Get your ticket "
              a [Href "https://www.eventbrite.co.uk/e/cloud-programming-with-f-tickets-48056860363"] [str "HERE"]
              str "."
            ]
          ]
        ]
    ]
    br []
    section [Class "hero is-small"] [
        div [Class "hero-body"] [
          div[ Class "standard-margin"] [
            h1 [Class "title is-2 title-bold"] [str "SPONSORS."]
            h4 [Class "subtitle is-5 neon-green"] [str "Many thanks to our fabulous sponsors who make this conference possible!"]
          ]
          div [Class "sponsors"] [
            div[ Class "columns"] [
              linkImage "is-2" "sponsor-fsharp" "fsharp.png" "http://fsharp.org/"
              linkImage "is-6" "sponsor-comp" "compositional-it.png" "https://compositional-it.com/"
            ]
          ]
        ]
    ]
    br []
    div [Class "container"] [
      div[ Class "standard-margin"] [
        div [Class "columns"] [
          div [Class "column is-three-quarters"] [
            h3 [Class "title is-2"] [str "CODE OF CONDUCT"]
            h4 [Class "subtitle is-4 neon-green"] [str "Be respectful, be open, and be considerate."]
          ]
          div [Class "column"] [
            a [Href "http://diversitycharter.org/"] [
              figure [Class "image"] [
                img [
                  Style [Margin "0 auto"; Width "auto"]
                  Src "img/diversity.png"]
              ]
            ]
          ]
        ]
        div [Class "content"] [
          p [] [
            str "Our conference is dedicated to providing a harassment-free conference experience for everyone, regardless of gender, gender identity and expression, age, sexual orientation, disability, physical appearance, body size, race, or religion (or lack thereof). We do not tolerate harassment of conference participants in any form. Sexual language and imagery is not appropriate for any conference venue, including talks, workshops, parties, Twitter and other online media. Conference participants violating these rules may be sanctioned or expelled from the conference without a refund at the discretion of the conference organisers. "
            a [Href "http://confcodeofconduct.com/"] [str "Read more."]
          ]
        ]
      ]
    ]
  ]
