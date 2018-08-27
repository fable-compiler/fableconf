module Info.View

open Fable.Helpers.React
open Fable.Helpers.React.Props
open Fable.Core.JsInterop
open Fulma

let root =
  div [Style [!!("overflowY", "hidden")]] [

    div [Class "container"] [
      div [Class "standard-margin"] [
          h1 [Class "title is-1 title-bold"] [str "Venue."]
          h3 [Class "subtitle is-4"] [
            span [Class "neon-green title-bold"] [str "Microsoft Berlin"]
            br []
            span [Class "title-light neon-green"] [str "Unter den Linden 17, 10117 Berlin,"]
            span [Class "title-light neon-green"] [str "Germany"]
          ]
          h3 [Class "subtitle is-4"] [
            span [Class "title-light neon-green"] [str "26-27 october"]
          ]
      ]
    ]
    br []
    section [Class "hero is-large is-primary venue-img"] [
      div [Class "hero-body"] [
        div [Class "container"] []
      ]
    ]
    br []
    div [Class "container"] [
      div [Class "content standard-margin"] [
        h3 [Class "subtitle is-4"] [
          span [Class "red title-bold"] [str "THE LOCATION"]
        ]
        p [] [str "FableConf will take place at Microsoft facilities located in Unter den Linden 17, one of the few well-preserved historic sites which continues to contribute to the special flair of Berlin Mitte. Originally a high-class hotel, it still attracts visitors today.
The ground floor with its multifunctional spaces and the adjacent Digital Eatery provide an extraordinary atmosphere between the traditional and the modern."]
        p [] [str "Berlin is a vibrant city and a popular touristic destination. Make the most of your trip and relax during the weekend enjoying its world-famous museums and spots, among many other attractions."]
      ]
    ]
    br []
    //h4 [Class "title is-4 has-text-centered"] [str "Transportation info coming soon!"]
    iframe [
      Class "google-map"
      Src "https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d2427.9186937927734!2d13.388362651689432!3d52.516810479714536!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x47a851db450c485b%3A0x515d86e5ad24fd36!2sMicrosoft+Berlin!5e0!3m2!1sen!2ses!4v1529050295073"
      AllowFullScreen true
    ] []
  ]
