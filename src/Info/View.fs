module Info.View

open Fable.Helpers.React
open Fable.Helpers.React.Props
open Fable.Core.JsInterop
open Fulma.Elements

let root =
  div [Style [!!("overflowY", "hidden")]] [
    section [ClassName "hero is-medium is-primary cap-sciences"] [
      div [ClassName "hero-body"] [
        div [ClassName "container"] [
          h1 [ClassName "title is-1"] [str "Cap Sciences"]
          h3 [ClassName "subtitle is-3"] [str "Bordeaux, France"]
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
    article [ClassName "message is-primary"] [
      div [ClassName "message-body has-text-centered"] [
        p [] [
          str "Please note workshops will take place at "
          a [Href "http://www.coolworking.fr/"] [str "Coolworking"]
          str "."
        ]
      ]
    ]
    div [ClassName "container"] [
      div [ClassName "content"] [
        // h1 [ClassName "has-text-centered"] [str "Transportation"]
        h2 [] [str "Direct Shuttle from the airport to the train station"]
        ul [] [
          li [] [strong [] [str "time: "]; str "30'"]
          li [] [strong [] [str "price: "]; str "8€ (one way)"]
          li [] [a [Href "http://30direct.com/en/high-season-schedule/"] [str "Timetables"]]
          li [] [a [Href "http://30direct.com/en/tarifs-vente-tickets/"] [str "Fares"]]
        ]
        h2 [] [str "Tram from the train station to Cap-Sciences"]
        ul [] [
          li [] [strong [] [str "time: "]; str "22'"]
          li [] [strong [] [str "price: "]; str "1.50€ (one way)"]
        ]
        ol [] [
          li [] [str "Tram C from Train station (Gare St Jean) to Quinconces (direction> Gare de Blanquefort) (15 minutes)"]
          li [] [str "Change tram lines"]
          li [] [str "Tram B from Quinconces to Cité du vin (7 minutes)"]
        ]
        p [] [str "More info at "; a [Href "https://www.infotbm.com/en"] [str "www.infotbm.com"]]
        br []
      ]
    ]
    iframe [
      ClassName "google-map"
      Src "https://www.google.com/maps/embed?pb=!1m24!1m8!1m3!1d22631.531410073396!2d-0.5816984!3d44.8431262!3m2!1i1024!2i768!4f13.1!4m13!3e3!4m5!1s0xd5526492c8365af%3A0x24c6bd58a0525021!2sGare+Saint-Jean%2C+Bordeaux%2C+France!3m2!1d44.8259081!2d-0.5567968!4m5!1s0xd55288fe041f36f%3A0xc849cfd5c16a7bb8!2sCap+Sciences%2C+Hangar+20%2C+Quai+de+Bacalan%2C+33300+Bordeaux%2C+France!3m2!1d44.859851!2d-0.554119!5e0!3m2!1sen!2sus!4v1500308157035"
      AllowFullScreen true
    ] []
  ]
