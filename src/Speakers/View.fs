module Speakers.View

open Fable.Core
open Fable.Core.JsInterop
open Fable.Helpers.React
open Fable.Helpers.React.Props
open Elmish.Bulma.Elements
open Types

let modalView (speaker: Speaker) (talk: Talk) =
  div [ClassName "modal is-active"] [
    a [
      Href "#speakers"
      ClassName "modal-background"
    ] []
    div [ClassName "modal-content"] [
      div [ClassName "box"] [
        div [ClassName "content"] [
          yield h1 [] [str talk.title]
          yield talk.content
          match speaker.bio with
          | Some bio ->
            yield h3 [] [str speaker.name]
            yield p [] [str bio]
          | None -> ()
        ]
      ]
    ]
    // button [
    //   ClassName "modal-close is-large"
    //   OnClick (fun _ -> dispatch CloseModal)
    // ] []
  ]

let cardView (speaker: Speaker) =
  div [
    ClassName "card"
    Style [CSSProp.Width "300px"; Margin "5px"]
  ] [
    div [ClassName "card-image"] [
      Image.image [] [
        img [
          Src speaker.picture
          Style [
            CSSProp.Width "auto"
            CSSProp.Height "auto"
            MaxHeight "300px"
            MaxWidth "300px"
            Margin "auto"
          ]
        ]
      ]
    ]
    div [ClassName "card-content"] [
      a [
        Href ("#speakers/" + speaker.shortname)
        ClassName "content"
      ] [
        p [ClassName "title is-4 has-text-centered"] [str speaker.name]
        p [ClassName "subtitle is-6 has-text-centered"] [str speaker.talk.title]
      ]
      div [
        ClassName "level is-mobile"
        Style [MarginTop "20px"]
      ] [
        speaker.twitter |> Option.map (fun username ->
          a [ClassName "level-item"; Href ("https://twitter.com/" + username) ] [
            Icon.icon [Icon.isMedium] [i [ClassName "fa fa-twitter"] []]
          ]) |> opt
        speaker.github |> Option.map (fun username ->
          a [ClassName "level-item"; Href ("https://github.com/" + username) ] [
            Icon.icon [Icon.isMedium] [i [ClassName "fa fa-github"] []]
          ]) |> opt
      ]
    ]
  ]

let root model =
  div [
    Style [
      Display "flex"
      FlexWrap "wrap"
      JustifyContent "center"
    ]
  ] [
    yield! model.speakers |> List.map cardView
    yield model.modal |> Option.map (fun (speaker, talk) ->
      modalView speaker talk) |> opt
  ]
