module Info.View

open Fable.Helpers.React
open Fable.Helpers.React.Props
open Fable.Core.JsInterop
open Fulma

let root =
  div [Style [!!("overflowY", "hidden")]] [

    div [ClassName "container"] [
      div [ClassName "standard-margin"] [
          h1 [ClassName "title is-1 title-bold"] [str "Venue."]
          h3 [ClassName "subtitle is-4"] [
            span [ClassName "neon-green title-bold"] [str "Microsoft Berlin"]
            br []
            span [ClassName "title-light neon-green"] [str "Unter den Linden 17, 10117 Berlin,"]
            span [ClassName "title-light neon-green"] [str "Germany"]
          ]
          h3 [ClassName "subtitle is-4"] [
            span [ClassName "title-light neon-green"] [str "26-27 october"]
            br []
            span [ClassName "title-light neon-green"] [str "8:15"]
          ]
      ]
    ]

    section [ClassName "hero is-medium is-primary cap-sciences"] [
      div [ClassName "hero-body"] [
        div [ClassName "container"] [
        ]
      ]
    ]
    // Image.image [] [img [Src "img/cap-sciences.jpg"]]
    // br []
    // h3 [ClassName "title is-3"] [str "Cap Sciences"]
    // h5 [ClassName "subtitle is-5"] [str "Bordeaux, France"]
    div [ClassName "container"] [
      div [ClassName "content standard-margin"] [
        h3 [ClassName "subtitle is-4"] [
          span [ClassName "red title-bold"] [str "THE LOCATION"]
        ]
        p [] [
          str "FableConf will take place at Microsoft facilities located in Unter den Linden 17, one of the few well-preserved historic sites which continues to contribute to the special flair of Berlin Mitte. Originally a high-class hotel, it still attracts visitors today.
The ground floor with its multifunctional spaces and the adjacent Digital Eatery provide an extraordinary atmosphere between the traditional and the modern."
        ]
        p [] [str "Berlin is a vibrant city and a popular touristic destination. Make the most of your trip and relax during the weekend enjoying its world-famous museums and spots, among many other attractions."]
        br []
        (*
        h3 [ClassName "subtitle is-4"] [
          span [ClassName "red title-bold"] [str "Transportation"]
        ]
        p [] [
          str "Information coming soon"
        ]
        *)
      ]
    ]
    // article [ClassName "message is-primary"] [
    //   div [ClassName "message-body has-text-centered"] [
    //     p [] [
    //       str "Please note workshops will take place at "
    //       a [Href "https://www.google.fr/maps/place/Bordeaux+Digital+Campus/@44.863924,-0.5613694,16z/data=!4m5!3m4!1s0xd54d9a55ce015bf:0xd2da001c64f8dddc!8m2!3d44.863924!4d-0.556992"] [str "Bordeaux Digital Campus"]
    //       str ", five minutes walking from Cap Sciences."
    //     ]
    //   ]
    // ]
    //h4 [Class "title is-4 has-text-centered"] [str "Transportation info coming soon!"]
    //br []
    // div [ClassName "container"] [
    //   div [ClassName "content"] [
    //     // h1 [ClassName "has-text-centered"] [str "Transportation"]
    //     h2 [] [str "Direct Shuttle from the airport to the train station"]
    //     ul [] [
    //       li [] [strong [] [str "time: "]; str "30'"]
    //       li [] [strong [] [str "price: "]; str "8€ (one way)"]
    //       li [] [a [Href "http://30direct.com/en/high-season-schedule/"] [str "Timetables"]]
    //       li [] [a [Href "http://30direct.com/en/tarifs-vente-tickets/"] [str "Fares"]]
    //     ]
    //     h2 [] [str "Tram from the train station to Cap-Sciences"]
    //     ul [] [
    //       li [] [strong [] [str "time: "]; str "22'"]
    //       li [] [strong [] [str "price: "]; str "1.50€ (one way)"]
    //     ]
    //     ol [] [
    //       li [] [str "Tram C from Train station (Gare St Jean) to Quinconces (direction> Gare de Blanquefort) (15 minutes)"]
    //       li [] [str "Change tram lines"]
    //       li [] [str "Tram B from Quinconces to Cité du vin (7 minutes)"]
    //     ]
    //     p [] [str "More info at "; a [Href "https://www.infotbm.com/en"] [str "www.infotbm.com"]]
    //     br []
    //   ]
    // ]
    iframe [
      ClassName "google-map"
      Src "https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d2427.9186937927734!2d13.388362651689432!3d52.516810479714536!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x47a851db450c485b%3A0x515d86e5ad24fd36!2sMicrosoft+Berlin!5e0!3m2!1sen!2ses!4v1529050295073"
      AllowFullScreen true
    ] []
  ]
