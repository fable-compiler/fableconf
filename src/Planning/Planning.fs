namespace Planning

open Fable.Core
open Fable.Core.JsInterop
open Fable.Helpers.React
open Fable.Helpers.React.Props
open Global
open Speakers.Types
open Fable.Import.React
open Fulma

module Types =
  type EventKind = KindOne | KindTwo | KindThree

  type Level = Beginner | Intermediate | Expert | AllLevels
  type Track =
    {
      Title:string
      Speaker:Speaker option
      Description:ReactElement option
      Kind:EventKind option
      Level:Level option
    }

  type DayEvent =
    {
      Time:string
      Tracks:Track list
    }

  type Day =
    {
      Date:string
      Events : DayEvent list
    }

  type Model =
    { Days: Day list
      Highlight: Speaker option }

  type Msg =
    | OpenModal of Speaker
    | CloseModal

module State =
  open Types

  let init() : Model =
    let takeABreak title time =
        {Time=time; Tracks=[{Level=None;Speaker=None;Title=title;Description=None;Kind=None}]}

    let event speaker title desc kind level=
      let speaker =
        match speaker with
        | Some name ->
          Some (speakersMap.Item name)
        | None -> None
      {
        Speaker=speaker
        Title=title
        Description=Some desc
        Kind=Some kind
        Level = Some level
      }

    let eventFromSpeaker speaker kind level=
      let speaker = speakersMap.Item speaker
      {
        Speaker=Some speaker
        Title=speaker.talk.title
        Description=Some speaker.talk.content
        Kind=Some kind
        Level = Some level
      }

    let talk speaker=
      eventFromSpeaker speaker KindOne

    let keynote speaker =
      eventFromSpeaker speaker KindThree

    let ws speaker =
      eventFromSpeaker speaker KindTwo

    let days =
     [{
        Date="Day One - Friday 26 Oct. 2018"
        Events=[
          {Time="TRACKS"; Tracks=[{Level=None;Speaker=None;Title="Fable";Description=None;Kind=Some KindOne};{Speaker=None;Title="Remmidemmi";Level=None;Description=None;Kind=Some KindTwo}]}
          takeABreak "Introductory Breakfast" "08:15"
          {
            Time="09:15"
            Tracks=[
              keynote "maxime" AllLevels
            ]
          }
          takeABreak "Coffee Break" "10:15"
          { Time="10:30"
            Tracks=[
              talk "gien" Intermediate
              ws "sia" Expert
            ]
          }
          takeABreak "Coffee Break" "11:15"
          { Time="11:30"
            Tracks=[
              talk "evelina" Beginner
              ws "jeff" AllLevels
            ]
          }
          takeABreak "Lunch" "12:15"
          { Time="14:00"
            Tracks=[
              talk "julien" Intermediate
              ws "krzysztof" Expert
            ]
          }
          takeABreak "Coffee Break" "14:45"
          { Time="15:00"
            Tracks=[
              talk "tomasz" AllLevels
              ws "romanp" Beginner
            ]
          }
          takeABreak "Coffee Break" "15:45"
          { Time="16:00"
            Tracks=[
              talk "zaid" Intermediate
              ws "romans" Expert
            ]
          }
          takeABreak "Last Coffee Break" "16:30"
          { Time="16:45"
            Tracks=[
              keynote "ketleen" AllLevels
            ]
          }
          takeABreak "That's all folks!" "17:30"
        ]
      }

      {
        Date="Day Two - Saturday 27 Oct. 2018"
        Events=[
          {Time="TRACKS"; Tracks=[{Level=None;Speaker=None;Title="Workshops";Description=None;Kind=Some KindOne};{Speaker=None;Title="Hackspace";Description=None;Kind=Some KindTwo;Level=None}]}
          takeABreak "Breakfast" "08:15"
          {
            Time="09:15"
            Tracks=[
              event (Some "zaid") "Great workshop" (str "You will learn this and that...") KindOne AllLevels
              event None "Great hackspace" (str "You will learn this and that...") KindTwo AllLevels
            ]
          }
          takeABreak "Coffee Break" "10:15"
          { Time="10:30"
            Tracks=[
              event (Some "francois") "Great workshop" (str "You will learn this and that...") KindOne AllLevels
              event None "Great hackspace" (str "You will learn this and that...") KindTwo AllLevels
            ]
          }
          takeABreak "Coffee Break" "11:30"
          { Time="11:45"
            Tracks=[
              event (Some "alfonso") "Great workshop" (str "You will learn this and that...") KindOne AllLevels
              event None "Great hackspace" (str "You will learn this and that...") KindTwo AllLevels
            ]
          }
          takeABreak "Lunch" "12:45"
          { Time="14:00"
            Tracks=[
              event (Some "stachu") "Great workshop" (str "You will learn this and that...") KindOne AllLevels
              event None "Great hackspace" (str "You will learn this and that...") KindTwo AllLevels
            ]
          }
          takeABreak "That's all folks! Have fun in Berlin!" "15:00"
        ]
      }]

    { Days = days; Highlight = None }

  let update msg model =
    match msg with
    | OpenModal s -> { model with Highlight = Some s }
    | CloseModal -> { model with Highlight = None }

module View =

  open Types

  let prepareDay dispatch (day:Day) =
    let buildEvent i (event:DayEvent) =
      let count = float event.Tracks.Length
      let max = int (System.Math.Floor ( 10. / count))
      let columnWidth = sprintf "is-%i" max
      let columnClass = sprintf "column column-with-border %s " columnWidth
      let lines =
        event.Tracks
          |> List.map( fun track ->
            let kindClass, kindName =
              match track.Kind with
              | Some kind ->
                match kind with
                | KindOne ->
                  "red", " //////"
                | KindTwo ->
                  "electric-blue", " //////"
                | _ ->
                  "", ""
              | None -> "",""

            let title = h4 [Class "subtitle is-4 white";Style[Padding "0";Margin "0"]] [
              str track.Title
              span [Class kindClass] [str kindName]
            ]

            let speakerName =
              match track.Speaker with
              | Some s ->
                h5 [Class (sprintf "%s is-5 title-light " kindClass)
                    OnClick (fun _ -> OpenModal s |> dispatch)
                    Style [Padding "0"; Margin "0"; Cursor "pointer"]]
                   [str s.name]
              | None -> str ""

            let tag=
              match track.Level with
              | Some level ->
                match level with
                | AllLevels ->
                  span[Class "tag is-Light"] [str "All Levels"]
                | Beginner ->
                  span[Class "tag is-success"] [str "Beginner"]
                | Intermediate ->
                  span[Class "tag is-primary"] [str "Intermediate"]
                | Expert ->
                  span[Class "tag is-black"] [str "Expert"]
              | None -> str ""

            match track.Description with
            | Some desc ->
              div[Class columnClass] [
                title
                speakerName
                br[]
                span[] [ desc]
                br[]
                tag
              ]
            | None ->
              div[Class columnClass] [
                title
              ]
          )

      let color = if i % 2 = 0 then "grey" else "dark"
      div[Class (sprintf "columns %s" color)]
        ([
          div[Class "column column-with-border is-2"] [
              h4 [Class "subtitle is-4 neon-green"] [str event.Time]
          ]
        ] @ lines)

    div[Class "container day"]
      [
        h2 [Class "title is-2"] [str day.Date]
        div[Class ""] (day.Events |> List.mapi buildEvent)
      ]

  let cardView (speaker: Speaker) =
    div [
      Class "card"
      Style [CSSProp.Width "300px"; Margin "5px"]
    ] [
      div [Class "card-image"] [
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
      div [Class "card-content"] [
        yield p [Class "title is-4 has-text-centered"] [str speaker.name]
        yield p [Class "subtitle is-6 has-text-centered"] [str speaker.talk.title]
        match speaker.bio with
        | Some bio -> yield p [] [str bio]
        | None -> ()
        yield div [
          Class "level is-mobile"
          Style [MarginTop "20px"]
        ] [
          speaker.twitter |> Option.map (fun username ->
            a [Class "level-item"; Href ("https://twitter.com/" + username) ] [
              Icon.icon [Icon.Size Size.IsMedium] [i [Class "fa fa-twitter"] []]
            ]) |> ofOption
          speaker.github |> Option.map (fun username ->
            a [Class "level-item"; Href ("https://github.com/" + username) ] [
              Icon.icon [Icon.Size Size.IsMedium] [i [Class "fa fa-github"] []]
            ]) |> ofOption
        ]
      ]
    ]

  let root (model: Model) dispatch =

    let events =
      model.Days
      |> List.map (prepareDay dispatch)

    div [] [
        match model.Highlight with
        | Some speaker ->
          yield Modal.modal [ Modal.IsActive true ]
            [ Modal.background [ Props [ OnClick (fun _ -> dispatch CloseModal) ] ] [ ]
              Modal.content [ Props [Style [Width "350px"]] ]
                [ Box.box' [ ]
                    [ cardView speaker ] ]
              Modal.close [ Modal.Close.Size IsLarge
                            Modal.Close.OnClick (fun _ -> dispatch CloseModal) ] [ ] ]
        | None -> ()

        yield div[ Class "container planning"] [
          div[ Class ""] [
            h1 [Class "title is-1 title-bold"] [str "Planning."]
            div[] events
          ]
        ]
    ]
