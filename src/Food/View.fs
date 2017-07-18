module Food.View

open Fable.Helpers.React
open Fable.Helpers.React.Props
open Fable.Core.JsInterop
open Elmish.Bulma.Elements

let firstColumn =
  div [ClassName "column is-half"] [
    div [ClassName "content"] [
      h2 [] [str "Breakfast (8:30-9:30)"]
      p [] [strong [] [str "Assortiment de mini-viennoiserie"]]
      ul [] [
        li [] [str "Mini croissant"]
        li [] [str "Mini pains aux raisins"]
        li [] [str "Mini chocolatines"]
      ]
      p [] [strong [] [str "Boissons"]]
      ul [] [
        li [] [str "Café"]
        li [] [str "Assortiment de thés"]
        li [] [str "Jus d'orange"]
        li [] [str "Eau minérale plate"]
      ]
      h2 [] [str "All morning"]
      ul [] [
        li [] [str "Café"]
        li [] [str "Assortiment de thés"]
        li [] [str "Jus d'ananas"]
        li [] [str "Eau minérale plate"]
      ]
      h2 [] [str "Afternoon"]
      ul [] [
        li [] [str "Café"]
        li [] [str "Boissons Eaux plates et eaux pétillantes"]
      ]
    ]
  ]

let secondColumn =
  div [ClassName "column is-half"] [
    div [ClassName "content"] [
      h2 [] [str "Lunch (12:30-14:00)"]
      p [] [strong [] [str "Buffet debout Les pièces à la pique"]]
      ul [] [
        li [] [str "Pointe d'asperges jambon parmesan"]
        li [] [str "Macaron rouge à la basquaise"]
      ]
      p [] [strong [] [str "La découpe"]]
      ul [] [
        li [] [str "Assortiment de charcuteries locales"]
        li [] [str "Condiments et pain de campagne tranché"]
      ]
      p [] [strong [] [str "Le buffet des salades"]]
      ul [] [
        li [] [str "Salade de tomates du marché"]
        li [] [str "Mozza pesto et roquette"]
        li [] [str "Salade césar: poulet rôti, mesclun, pdt, anchois, croûton, parmesan, œuf dur, sauce césar"]
      ]
      p [] [strong [] [str "Les mets chauds"]]
      ul [] [
        li [] [str "Cabillaud en croûte de cacahuètes soufflées"]
        li [] [str "Fricassée de poulet au citron et grenailles rissolées"]
      ]
      p [] [strong [] [str "Les fromages"]]
      ul [] [
        li [] [str "Planche de trois fromages de pays et sa confiture"]
      ]
      p [] [strong [] [str "Les desserts"]]
      ul [] [
        li [] [str "Salade de fruits de saison"]
        li [] [str "Gâteau basque à la crème d'amande"]
        li [] [str "Mousse au chocolat lactée"]
        li [] [str "Cannelé bordelais"]
      ]
    ]
  ]


let root =
  div [] [
    Image.image [] [img [Src "img/macaron.jpg"]]
    div [ClassName "container"] [
      br []
      article [ClassName "message is-primary"] [
        div [ClassName "message-body has-text-centered"] [
          p [] [
            str "Sorry, no fast-food at FableConf..."
            strong [] [str " This is France! "]
            str "Our attendees will be pampered with a special selection of local cuisine. Have a look at the wonderful menu we are preparing for you. But beware, it'll make your mouth water ;)"
          ]
          br []
          p [] [
            str "Everything in French, of course. "
            em [] [str "Because food tastes much better in French!"]
          ]
        ]
      ]
      div [ClassName "columns"] [
        firstColumn
        secondColumn
      ]
      h4 [ClassName "title is-4 has-text-centered"] [
        str "Caterer: "
        a [Href "http://www.lagrifgourmande.fr/"] [str "La Grif' Gourmande"]
      ]
      br []
    ]
  ]
