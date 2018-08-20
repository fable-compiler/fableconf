module Speakers.View

open Fable.Core
open Fable.Core.JsInterop
open Fable.Helpers.React
open Fable.Helpers.React.Props
open Fulma
open Types
open Global

[<RequireQualifiedAccess>]
module Seq =
    let SplitInto n s =
        seq {
            let r = ResizeArray<_>()
            for x in s do
                r.Add(x)
                if r.Count = n then
                    yield r.ToArray()
                    r.Clear()
            if r.Count <> 0 then
                yield r.ToArray()
        }

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

  let random = System.Random()
  let rnd = random.Next 3
  let color =
    match rnd with
    | x when x <= 0 -> "red"
    | x when x <= 1 -> "green"
    | _ -> "blue"

  let speakerClass = sprintf "speaker-photo %s" color
  div[ ClassName "column" ] [
    div[ ClassName "columns"] [
      div[ ClassName "column" ] [
        div [ClassName speakerClass; Style [BackgroundImage (sprintf "url('%s')" speaker.picture)]] [
        ]
      ]
      div[ ClassName "column content" ] [
          p [ClassName "title is-4 "] [str speaker.name]
          p [ClassName "subtitle is-6 neon-green"] [str speaker.talk.title]
          speaker.talk.content
      ]
    ]
  ]

  (*
  div [ ClassName "column" ] [
    div [
      ClassName "card"
      Style [CSSProp.Width "300px"]
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
              Icon.icon [Icon.Size Size.IsMedium] [i [ClassName "fa fa-twitter"] []]
            ]) |> ofOption
          speaker.github |> Option.map (fun username ->
            a [ClassName "level-item"; Href ("https://github.com/" + username) ] [
              Icon.icon [Icon.Size Size.IsMedium] [i [ClassName "fa fa-github"] []]
            ]) |> ofOption
        ]
      ]
    ]
  ]
  *)

let root model =

  let components =
    [
      div[ ClassName "container"] [
        div[ ClassName "standard-margin"] [
          h1 [ClassName "title is-1 title-bold"] [str "SPEAKERS."]
          h4 [ClassName "subtitle is-3 neon-green"] [str "Discover your fellow F# speakers!"]
        ]
      ]
    ]

  let elements =

    let speakerCards =
        model.speakers
        |> Seq.SplitInto 2
        |> Seq.map( fun currentList ->
          let cards = currentList |> Seq.toList |> List.map cardView
          div [ClassName "container speakers columns"] cards
        )
        |> Seq.toList

    let modals = [ model.modal |> Option.map (fun (speaker, talk) -> modalView speaker talk) |> ofOption ]

    [
      div[ ClassName ""] (speakerCards @ modals)
    ]

  div [
    Style [
      Display "flex"
      FlexWrap "wrap"
      JustifyContent "center"
    ]
  ] (components @ elements)
