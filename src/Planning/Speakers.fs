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
       content = str "TBD: Come back soon!"
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
        content = str "TBD: Come back soon!"
      }
    bio = Some "Krzysztof is a software developer, consultant, open source contributor and active member of the F# community."
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
        content = str "TBD: Come back soon!"
      }
    bio = Some "
Gien Verschatse
Gien is a software developer with 8 years of experience, mainly in a .NET environment. She is a strong believer of continuously learning by deliberate practice and knowledge sharing, which is why she takes part in the organization of two Belgian communities, namely DDDBE and SoCraTesBE."
    twitter = Some "selketjah"
    github = Some "selketjah"
  }

let Sia =
  {
    shortname = "sia"
    name = "Sia"
    picture = "img/Mystery.png"
    talk =
      { title = "Azure Functions Deep Dive"
        content = str "TBD: Come back soon!"
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
        content = str "TBD: Come back soon!"
      }
    bio = Some "Evelina is a machine learning researcher working in bioinformatics, trying to reverse-engineer cancer at University of Cambridge. When not at work, she likes to play with fun datasets to extract interesting insights."
    twitter = Some "evelgab"
    github = Some "evelinag"
  }

let Jeff =
  {
    shortname = "jeff"
    name = "Jeff Hollan"
    picture = "img/Mystery.png"
    talk =
      { title = "Azure Functions"
        content = str "TBD: Come back soon!"
      }
    bio = None
    twitter = None
    github = None
  }

let Julien =
  {
    shortname = "julien"
    name = "Julien Roncaglia"
    picture = "img/Mystery.png"
    talk =
      { title = "Performance tricks for Fable.React apps"
        content = str "TBD: Come back soon!"
      }
    bio = None
    twitter = Some "virtualblackfox"
    github = Some "vbfox"
  }

let Tomasz =
  {
    shortname = "tomasz"
    name = "Tomasz Heimowski"
    picture = "img/Tomasz.png"
    talk =
      { title = "Build a game with Fable in 45 minutes"
        content = str "TBD: Come back soon!"
      }
    bio = Some "Tomasz is a passionate developer whose main areas of interest are F# and Functional Programming in general. As a Senior Software Engineer at Datto he tackles problems from various domains. In his free time, apart from contributing to OSS projects and learning new tech stuff, he enjoys lifting weights as well as dancing."
    twitter = Some "theimowski"
    github = Some "theimowski"
  }

let RomanP =
  {
    shortname = "romanp"
    name = "Roman Provazník"
    picture = "img/RomanP.jpg"
    talk =
      { title = "Event Sourcing with Azure Cosmos DB"
        content = str "Let me take you on a journey through the development of a web-based event sourcing application in F# & Azure Cosmos DB. I'll show you all the pain points and dead ends we went through and how we end up with a sane design. Warning: this talk contains some bad decisions you definitely do not want to repeat."
      }
    bio = Some "Roman is the founder of a Czech F# community called FSharping, who works in CN Group as an F# team leader. You can find him mostly in a good mood and ready to chat about the things he loves: F#, functional programming, domain-driven design, event sourcing systems, web development and drums."
    twitter = Some "rprovaznik"
    github = Some "dzoukr"
  }

let Zaid =
  {
    shortname = "zaid"
    name = "Zaid Ajaj"
    picture = "img/Zaid.jpg"
    talk =
      { title = "Scaling Elmish Applications"
        content = str "Understanding the techniques of building large Elmish applications by example"
      }
    bio = None
    twitter = Some "zaid_ajaj"
    github = Some "Zaid-Ajaj"
  }

let RomanS =
  {
    shortname = "romans"
    name = "Roman Sachse"
    picture = "img/RomanS.jpg"
    talk =
      { title = "Domain Driven UI with SAFE-Stack"
        content = str "Domain Driven Design is a way of thinking about the needs of the customers first and putting an emphasis on their language and interactions. The outcome of this approach is mostly applied to the backend of applications, but a semantic domain model also benefits the UI. Unfortunately these semantics are often lost in translation when transferred to the frontend. I will show you a functional approach that allows you to actually reuse your domain types by combining CQRS/Event-Sourcing on the backend and the Elm architecture on the frontend with an overall messaging architecture."
      }
    bio = Some "Roman Sachse started programming 16 years ago rather by accident shortly after founding his first company when he realized how much fun it was building the stuff he was working on by himself. This set him out on a lifelong journey of learning everything about software development and computer science and he was particularly surprised to realize that this branch of science strongly depends on two fields he was always interested in: people and communication. Roman is a proud father of three year old twin girls, holds a bachelors degree in Cognitive Science and a Masters degree in Computer Science and is currently mainly interested in Domain Driven Design, Functional Programming and the inner workings of software development teams."
    twitter = Some "R0MMSEN"
    github = Some "rommsen"
  }

let TBD =
  {
    shortname = "tbd"
    name = "TBD"
    picture = "img/Mystery.png"
    talk =
      { title = "TDB"
        content = str "TBD: Come back soon!"
      }
    bio = None
    twitter = None
    github = None
  }

let Stachu =
  {
    shortname = "stachu"
    name = "Stachu Korick"
    picture = "img/Mystery.png"
    talk =
      { title = ""
        content = str ""
      }
    bio = None
    twitter = None
    github = None
  }



let Isaac =
  {
    shortname = "isaac"
    name = "Isaac Abraham"
    picture = "img/Isaac.png"
    talk =
      { title = "SAFE-Stack dojo"
        content = str "This workshop is designed to allow you to experience the SAFE-Stack based on an ready-made application that you can build on top of. It will take around 90 minutes for you to complete if you have no experience in any of these technologies."
      }
    bio = None
    twitter = Some "isaac_abraham"
    github = Some "isaacabraham"
  }

let Steffen =
  {
    shortname = "steffen"
    name = "Steffen Forkmann"
    picture = "img/Steffen.jpg"
    talk =
      { title = "SAFE Tour planning"
        content = str "In this workshop you can apply your new SAFE-Stack knowledge to a real-world problem. We will get a list with orders and corresponding geodata and try to come up with an algorithm that schedules good tours for delivery. During the whole optimization process we will show the current best plan on a map."
      }
    bio = Some "Steffen Forkmann works as a Software Developer on large billing systems and therefore has great experience in applying functional concepts to real-world applications. Steffen is a very active part in the F# open source community and works on many OSS projects like FAKE - F# Make, Paket and the F# compiler."
    twitter = Some "sforkmann"
    github = Some "forki"
  }

let speakersMap =
  [ François
    Maxime
    Alfonso
    Krzysztof
    Gien
    Sia
    Evelina
    Jeff
    Julien
    Tomasz
    RomanP
    Zaid
    RomanS
    TBD
    Stachu
    Isaac
    Steffen
  ]
  |> List.map (fun x -> x.shortname,x)
  |> Map

