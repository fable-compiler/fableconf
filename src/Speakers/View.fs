module Speakers.View

open Fable.Core
open Fable.Core.JsInterop
open Fable.Helpers.React
open Fable.Helpers.React.Props
open Elmish.Bulma.Elements
open Types

let modalView dispatch (speaker: Speaker) (talk: Talk) =
  div [ClassName "modal is-active"] [
    div [
      ClassName "modal-background"
      OnClick (fun _ -> dispatch CloseModal)
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

let cardView dispatch (speaker: Speaker) =
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
      div [
        yield upcast ClassName "content"
        match speaker.talk with
        | Some talk ->
          yield upcast Style [!!("cursor", "pointer")]
          yield upcast OnClick (fun _ -> OpenModal(speaker, talk) |> dispatch)
        | None -> ()
      ] [
        p [ClassName "title is-4 has-text-centered"] [str speaker.name]
        p [ClassName "subtitle is-6 has-text-centered"] [str (match speaker.talk with Some t -> t.title | None -> "TBD")]
      ]
      div [ClassName "level is-mobile"] [
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

let root model dispatch =
  div [
    Style [
      Display "flex"
      FlexWrap "wrap"
      JustifyContent "center"
    ]
  ] [
    yield! model.speakers |> List.map (cardView dispatch)
    yield model.modal |> Option.map (fun (speaker, talk) ->
      modalView dispatch speaker talk) |> opt
  ]
