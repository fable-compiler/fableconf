namespace Page

module Schedule =
  open Types
  open Fable.React
  open Speakers


  module Types =

    type EventKind = KindOne | KindTwo | KindThree

    type Level = Beginner | Intermediate | Expert | AllLevels
    type Track =
      {
        Title:string
        Talk:Talk option
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
        SubtitleLink: (string*string) option
        Events : DayEvent list
      }

    type Model =
      { Days: Day list
        Highlight: Speaker option }

    type Msg =
      | OpenModal of Speaker
      | CloseModal

    let initialModel = 
      let takeABreak title time =
          {Time=time; Tracks=[{Level=None;Talk=None;Title=title;Kind=None}]}

      let eventFromSpeaker talk kind level =
        {
          Talk=Some talk
          Title=talk.Title
          Kind=Some kind
          Level = Some level
        }

      let track1 talk=
        eventFromSpeaker talk KindOne

      let track2 talk =
        eventFromSpeaker talk KindTwo

      let keynote talk =
        eventFromSpeaker talk KindThree

      let days =
        [
          {
            Date="Day One - Friday 6 Oct. 2019"
            SubtitleLink=None //Some ("Registration for dinner", "https://docs.google.com/forms/d/e/1FAIpQLSfdnhr1UOziLLfqKbAmdywHE1o4GY4GjIqUQN0xxES7dfuPpA/viewform")
            Events=[
              {Time="TRACKS"; Tracks=[{Level=None;Talk=None;Title="Track A";Kind=Some KindOne};{Level=None;Talk=None;Title="Track B";Kind=Some KindTwo}]}
              takeABreak "Introductory Breakfast" "08:15"
              {
                Time="09:15"
                Tracks=[
                  keynote 
                    {
                      Title="Keynote"
                      Video=None
                      Speakers=[Speakers.Alfonso;Speakers.François]
                      Content=str "Opening Keynote" 
                    } 
                    AllLevels
                ]
              }
              takeABreak "Coffee Break" "10:15"
              { Time="10:30"
                Tracks=[
                  track1 
                    {
                      Title="Remoting with Fable"
                      Video=None
                      Speakers=[Speakers.Zaid]
                      Content=str "Blah. Blah. Blah. Blah. Blah. Blah.Blah. Blah. Blah.Blah. Blah. Blah.Blah. Blah. Blah.Blah. Blah. Blah.Blah. Blah. Blah.Blah. Blah. Blah.Blah. Blah. Blah.Blah. Blah. Blah.Blah. Blah. Blah.Blah. Blah. Blah.Blah. Blah. Blah.Blah. Blah. Blah.Blah. Blah. Blah.Blah. Blah. Blah.Blah. Blah. Blah.Blah. Blah. Blah.Blah. Blah. Blah.Blah. Blah. Blah.Blah. Blah. Blah.Blah. Blah. Blah.Blah. Blah. Blah.Blah. Blah. Blah.Blah. Blah. Blah.Blah. Blah. Blah.Blah. Blah. Blah.Blah. Blah. Blah.Blah. Blah. Blah.Blah. Blah. Blah.Blah. Blah. Blah.Blah. Blah. Blah." 
                    } 
                    Intermediate
                  track2 
                    {
                      Title="Release the magic with Reactive MVU"
                      Video=None
                      Speakers=[Speakers.Dag]
                      Content=str "Blah. Blah. Blah." 
                    } 
                    AllLevels
                ]
              }
              takeABreak "Coffee Break" "11:15"
              { Time="11:30"
                Tracks=[
                  track1 
                    {
                      Title="Too Old for JavaScript, Still Young for Elmish"
                      Video=None
                      Speakers=[Speakers.Vagif]
                      Content=str "Blah. Blah. Blah." 
                    } 
                    Intermediate
                  track2 
                    {
                      Title="Server Side Rendering"
                      Video=None
                      Speakers=[Speakers.Steffen]
                      Content=str "Blah. Blah. Blah." 
                    } 
                    Expert
                ]
              }
              takeABreak "Lunch" "12:15"
              { Time="14:00"
                Tracks=[
                  track1 
                    {
                      Title="Datto Remote Management and Monitoring"
                      Video=None
                      Speakers=[Speakers.Tomasz]
                      Content=str "Blah. Blah. Blah." 
                    } 
                    AllLevels
                  track2 
                    {
                      Title="Building F# tooling in Fable"
                      Video=None
                      Speakers=[Speakers.Krzysztof]
                      Content=str "Blah. Blah. Blah." 
                    } 
                    Intermediate
                ]
              }
              takeABreak "Coffee Break" "14:45"
              { Time="15:00"
                Tracks=[
                  track1 
                    {
                      Title="Fable Breakout - Beyond Elmish"
                      Video=None
                      Speakers=[Speakers.Joerg]
                      Content=str "Blah. Blah. Blah." 
                    }                   
                    Intermediate
                  track2 
                    {
                      Title="From I to X: simple tricks to improve user experience"
                      Video=None
                      Speakers=[Speakers.Gien]
                      Content=str "Blah. Blah. Blah." 
                    }                   
                    Beginner
                ]
              }
              takeABreak "Coffee Break" "15:45"
              { Time="16:15"
                Tracks=[
                  track1 
                    {
                      Title="Intensive browser computation and Fable"
                      Video=None
                      Speakers=[Speakers.Colin]
                      Content=str "Blah. Blah. Blah." 
                    }                   
                    AllLevels
                  track2 
                    {
                      Title="Functional Adventures on High-Performance Computer Graphics"
                      Video=None
                      Speakers=[Speakers.Georg]
                      Content=str "Blah. Blah. Blah." 
                    }                   
                    Intermediate
                ]
              }
    //          takeABreak "Last Coffee Break" "17:00"
              { Time="17:00"
                Tracks=[
                  keynote 
                    {
                      Title="Closing Keynote"
                      Video=None
                      Speakers=[Speakers.Maxime]
                      Content=str "Blah. Blah. Blah." 
                    }
                    AllLevels
                ]
              }
              takeABreak "That's all folks!" "17:30"
            ]
          }
          {
            Date="Day Two - Saturday 7 Oct. 2019"
            SubtitleLink=None //Some ("Registration for morning workshops", "https://docs.google.com/forms/d/e/1FAIpQLSftL4EzYUHuiwgLdqQqkDJuBR-g_GVrIqrK-OdHNPHLtWtr-g/viewform")
            Events=[
              {Time="TRACKS"; Tracks=[{Level=None;Talk=None;Title="Workshops I";Kind=Some KindOne};{Talk=None;Title="Workshops II";Kind=Some KindTwo;Level=None}]}
              { Time="09:00"
                Tracks=[
                  track1 
                    {
                      Title="Interop with Fable: a deep dive"
                      Video=None
                      Speakers=[Speakers.Zaid]
                      Content=str "Blah. Blah. Blah." 
                    }                  
                    AllLevels
                  track2 
                    {
                      Title="Hands-on with SAFE Stack"
                      Video=None
                      Speakers=[Speakers.Tomasz]
                      Content=str "Blah. Blah. Blah." 
                    }
                    AllLevels
                ]
              }
              { Time="11:30"
                Tracks=[
                  track1 
                    {
                      Title="Fable.React performance"
                      Video=None
                      Speakers=[Speakers.Julien]
                      Content=str "Blah. Blah. Blah." 
                    }                                     
                    AllLevels
                  track2 
                    {
                      Title="Elmish.Bridge"
                      Video=None
                      Speakers=[Speakers.Diego]
                      Content=str "Blah. Blah. Blah." 
                    }                                     
                    AllLevels
                ]
              }
              takeABreak "Lunch" "13:15"
              { Time="14:00"
                Tracks=[
                  track1 
                    {
                      Title="Mindful Programming"
                      Video=None
                      Speakers=[Speakers.Alfonso;Speakers.François]
                      Content=str "Blah. Blah. Blah." 
                    }
                    AllLevels
                  track2 
                    {
                      Title="OMG! Fable!"
                      Video=None
                      Speakers=[Speakers.Alfonso;Speakers.François]
                      Content=str "Blah. Blah. Blah." 
                    }
                    AllLevels
                ]
              }
              takeABreak "That's all folks! Have fun in Antwerpen!" "17:30"
            ]
        }]

      { Days = days; Highlight = None }


  module State =

    open Types
    open Elmish

    let update msg model =
      match msg with
      | OpenModal s -> { model with Highlight = Some s }, Cmd.none
      | CloseModal -> { model with Highlight = None }, Cmd.none

  module View =

    open Types
    open Fulma
    open Fable.Core.JsInterop
    open Fable.React
    open Fable.React.Props
    open ReactReveal

    let cover =
        div [ Class "landing" ] [
          fade [
            div [ Class "inner" ] [
              div [ Class "info" ] [
                div [Class "ftitle"] [
                  div [Class "top"] [str "FABLE"]
                  div [Class "bottom"] [str "CONF'19"]
                ]
                div [Class "dates"] [
                  div [ Class "top"] [ str "6/7 sept 2019" ]
                  div [ Class "bottom"] [
                      strong [] [str "Schedule" ]
                  ]
                ]
              ]
              div [ Class "axxesLogo" ] [
                div [] [ strong [] [ str "powered by"] ]
                a [ Href "https://axxes.com/"; Target "_blank" ]
                  [ img [ Src "./axxesLogo.png" ] ]
              ]
            ]
          ]
        ]

    let agenda model dispatch= 
      let prepareDay dispatch (day:Day) =
        let buildEvent i (event:DayEvent) =
          let count = float event.Tracks.Length
          let max = int (System.Math.Floor ( 10. / count))
          let columnWidth = sprintf "is-%i" max
          let columnClass = sprintf "column column-with-border %s " columnWidth
          let lines =
            event.Tracks
              |> List.map( fun track ->
                let kindClass, kindName, color =
                  match track.Kind with
                  | Some kind ->
                    match kind with
                    | KindOne ->
                      "subtitle", " //////", "#bb4321"
                    | KindTwo ->
                      "blue", " //////", "#5b97b4"
                    | _ ->
                      "", "", ""
                  | None -> "","", ""

                let title = 
                  Heading.h4 [
                    Heading.Props [
                      Style[
                        Padding "0"
                        Margin "0"
                        FontWeight "600"
                        Color color
                      ]
                    ]
                  ] [
                    str track.Title
                    span [Class kindClass] [str kindName]
                  ]

                let speakerName =
                  match track.Talk with 
                  | Some talk -> 
                    talk.Speakers
                      |> List.map( fun s -> 
                        h6 [Class (sprintf "%s is-6 title-light " kindClass)
                            OnClick (fun _ -> OpenModal s |> dispatch)
                            Style [
                              Padding "0"
                              Margin "0"
                              MarginTop "0.5rem"
                              Cursor "pointer"
                              TextTransform "uppercase"
                              Color "black"]]
                          [str s.name]
                      )
                      |> fragment []
                    | None -> fragment [] []

                let tag =
                  match track.Level with
                  | Some level ->
                    match level with
                    | AllLevels ->
                      Tag.tag [ Tag.CustomClass "all"] [str "All Levels"]
                    | Beginner ->
                      Tag.tag [ Tag.CustomClass "beginner"] [str "Beginner"]
                    | Intermediate ->
                      Tag.tag [ Tag.CustomClass "intermediate"]  [str "Intermediate"]
                    | Expert ->
                      Tag.tag [ Tag.CustomClass "expert"]  [str "Expert"]
                  | None -> str ""


                let videoLink =
                  match track.Talk with
                  | Some t ->
                    match t.Video with
                    | Some v ->
                      div [] [
                        a [Class "tag is-Light"; Href v] [str "Video"]
                        str " "
                        tag
                      ]
                    | None -> tag
                  | None -> tag

                let contents = 
                  match track.Talk with
                  | None -> str ""
                  | Some talk ->  talk.Content

                div[
                  Class columnClass
                  Style [
                    BorderLeft "1px solid rgba(0,0,0,0.2)"
                  ]
                ] [
                  title
                  speakerName
                  br[]
                  div [
                    ClassName "contents"
                  ] [contents]
                  br []
                  videoLink 
                ]
              )

          let color = if i % 2 = 0 then "lighter" else "darker"
          Columns.columns 
            [ 
              Columns.CustomClass color
              Columns.Props [
                Style [
                  Color "white"
                ]
              ]
            ]
            ([
              Column.column [
                Column.Width (Screen.All, Column.Is2)
              ][
                  Heading.h4 [ 
                    Heading.Modifiers [
                      Modifier.TextAlignment (Screen.All,TextAlignment.Centered)
                    ]
                  ] [str event.Time]
              ] 
            ] @ lines)

        div[
          Class "container day"
        ]
          [
            yield Heading.h3 [
              Heading.Props [
                Style [
                  Margin "1.2rem"
                  //Color "#bb4321"
                ]
              ]
            ] [str day.Date]
            match day.SubtitleLink with
            | Some(txt,url) ->
              yield h4 [Class "subtitle is-4"] [a [Href url] [
                span [Style [TextDecoration "underline"]] [str txt]]]
            | None -> ()
            yield div[Class ""] (day.Events |> List.mapi buildEvent)
          ]

      let cardView (speaker: Speaker) =
        div [Class "card"] [
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
            //yield p [Class "subtitle is-6 has-text-centered"] [str speaker.talk.title]
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

      let events =
        model.Days
        |> List.map (prepareDay dispatch)

      div [] [
          match model.Highlight with
          | Some speaker ->
            yield Modal.modal [ Modal.IsActive true ]
              [ Modal.background [ Props [ OnClick (fun _ -> dispatch CloseModal) ] ] [ ]
                Modal.content [ ]
                  [ Box.box' [ ]
                      [ cardView speaker ] ]
                Modal.close [ Modal.Close.Size IsLarge
                              Modal.Close.OnClick (fun _ -> dispatch CloseModal) ] [ ] ]
          | None -> ()

          yield div[ Class "container planning"] [
            div[ Class ""] [
              //h1 [Class "title is-1 title-bold"] [str "Agenda."]
              div[] events
            ]
          ]
      ]

    let footer =
      let cesure =
          Level.item [ Level.Item.Modifiers [ Modifier.IsHidden (Screen.Mobile, true)]] [ str "|"]

      Footer.footer[ Props [ Id "footer"] ][
        Level.level [
        ] [
          Level.item [] [
            span [] [
              str "web design by "
              a [ Href "https://biensurgraphisme.com"; Target "_blank"] [ strong [] [str " Biensür Graphisme"] ]
            ]
          ]
          cesure
          Level.item [] [
            span [] [
              str "FABLE CONF is organised by Fable lovers. Powered this year by "
              a [ Href "https://axxes.com/"; Target "_blank"] [ str " Axxes!"]
            ]
          ]
        ]
      ]

    let root model dispatch =
      div [
        ClassName "addMargins"
      ] [
        cover
        agenda model dispatch
        footer
      ]
