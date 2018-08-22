module Speakers

open Fable.Import.React
open Fable.Helpers.React
open Fable.Helpers.React.Props
open Global

type Model =
  { modal: (Speaker * Talk) option
    speakers: Speaker list }

let François =
  {
    shortname = "francois"
    name = "François Nicaise"
    picture = "img/François.jpg"
    talk =
     { title = "Fable for busy dads: how Fable helps me to spend more time with my children"
       content = str "TBD"
     }
    bio = Some "François's been programming for over 20 years and finally found his way to F# and Fable. Before becoming a Freelancer, his main area of expertise was massive multiplayer web based video games like www.die2nite.com. Nowadays he's having fun on every single project, hardware or software based. He also spends a lot of time with kids through coding or business curriculums."
    twitter = Some "thewhitetigle"
    github = Some "whitetigle"
  }

let Maxime =
  {
    shortname = "maxime"
    name = "Maxime Mangel"
    picture = "img/maxime.png"
    talk =
     { title = "Keynote"
       content = str "? Come back soon! "
     }
    bio = Some "Maxime's has been testing a lot of languages over the past 10 years. Finally, he stopped with F# thanks to Fable discovery. He is working at Fleet Performance on a monitoring solution for mining quarry."
    twitter = Some "MangelMaxime"
    github = Some "MangelMaxime"
  }

let Alfonso =
  {
    shortname = "alfonso"
    name = "Alfonso García-Caro"
    picture = "img/Alfonso.jpeg"
    talk =
     { title = "Towards a new way of collaboration"
       content = str "TBD"
     }
    bio = Some "A linguist by heart and a programmer by choice, Alfonso has brought his passion for natural languages to the computing world. He is the creator of Fable and coauthor of the book \"Mastering F#\". He currently works at nsynk.de building control systems for digital art performances."
    twitter = Some "alfonsogcnunez"
    github = Some "alfonsogarciacaro"
  }

let Krzysztof =
  {
    shortname = "krzysztof"
    name = "Krzysztof Cieślak"
    picture = "img/Krzysztof.jpg"
    talk =
      { title = "Future of web development with F#"
        content = str "? Come back soon! "
      }
    bio = Some "Krzysztof is an software developer, consultant, open source contributor and active member of the F# community."
    twitter = Some "k_cieslak"
    github = Some "Krzysztof-Cieslak"
  }

let Gien =
  {
    shortname = "gien"
    name = "Gien Verschatse"
    picture = "img/Gien.jpg"
    talk =
      { title = "Becoming a full stack artist: a quest into the unknown"
        content = str "? Come back soon! "
      }
    bio = None
    twitter = None
    github = None
  }

let Sia =
  {
    shortname = "sia"
    name = "Sia"
    picture = "img/Indy.jpeg"
    talk =
      { title = "Azure Functions Deep Dive"
        content = str "? Come back soon! "
      }
    bio = None
    twitter = None
    github = None
  }

let Evelina =
  {
    shortname = "evelina"
    name = "Evelina Gabasova"
    picture = "img/Evelina.jpg"
    talk =
      { title = "Data visualization with Fable"
        content = str "? Come back soon! "
      }
    bio = None
    twitter = None
    github = None
  }

let Jeff =
  {
    shortname = "jeff"
    name = "Jeff Hollan"
    picture = "img/Indy.jpeg"
    talk =
      { title = "Azure Functions"
        content = str "? Come back soon! "
      }
    bio = None
    twitter = None
    github = None
  }

let Julien =
  {
    shortname = "julien"
    name = "Julien Roncaglia"
    picture = "img/Indy.jpeg"
    talk =
      { title = "Performance tricks for Fable/React apps?"
        content = str "? Come back soon! "
      }
    bio = None
    twitter = None
    github = None
  }

let Tomasz =
  {
    shortname = "tomasz"
    name = "Tomasz Heimowski"
    picture = "img/Tomasz.png"
    talk =
      { title = "Build a game in 45 minutes?"
        content = str "? Come back soon! "
      }
    bio = Some "Tomasz is a passionate developer whose main areas of interest are F# and Functional Programming in general. As a Senior Software Engineer at Datto he tackles problems from various domains. In his free time, apart from contributing to OSS projects and learning new tech stuff, he enjoys lifting weights as well as dancing."
    twitter = Some "theimowski"
    github = Some "theimowski"
  }

let RomanP =
  {
    shortname = "romanp"
    name = "Roman Provazník"
    picture = "img/Indy.jpeg"
    talk =
      { title = "Event Sourcing with SAFE-Stack"
        content = str "? Come back soon! "
      }
    bio = None
    twitter = None
    github = None
  }

let Zaid =
  {
    shortname = "zaid"
    name = "Zaid Ajar"
    picture = "img/Indy.jpeg"
    talk =
      { title = "Scaling Elmish Applications"
        content = str "? Come back soon! "
      }
    bio = None
    twitter = None
    github = None
  }

let RomanS =
  {
    shortname = "romans"
    name = "Roman Sachse"
    picture = "img/Indy.jpeg"
    talk =
      { title = "Domain Driven UI with SAFE-Stack"
        content = str "? Come back soon! "
      }
    bio = None
    twitter = None
    github = None
  }

let Ketleen =
  {
    shortname = "ketleen"
    name = "Ketleen Gabriels"
    picture = "img/Indy.jpeg"
    talk =
      { title = "Keynote"
        content = str "? Come back soon! "
      }
    bio = None
    twitter = None
    github = None
  }

let Stachu =
  {
    shortname = "stachu"
    name = "Stachu Korick"
    picture = "img/Indy.jpeg"
    talk =
      { title = ""
        content = str ""
      }
    bio = None
    twitter = None
    github = None
  }

let speakersMap =
  [ François.shortname, François
    Maxime.shortname, Maxime
    Alfonso.shortname, Alfonso
    Krzysztof.shortname, Krzysztof
    Gien.shortname, Gien
    Sia.shortname, Sia
    Evelina.shortname, Evelina
    Jeff.shortname, Jeff
    Julien.shortname, Julien
    Tomasz.shortname, Tomasz
    RomanP.shortname, RomanP
    Zaid.shortname, Zaid
    RomanS.shortname, RomanS
    Ketleen.shortname, Ketleen
    Stachu.shortname, Stachu
  ] |> Map

