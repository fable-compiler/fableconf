module Speakers

open Fable.Helpers.React
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
     { title = "Offline Progressive Web Apps with Fable & PouchDB"
       content = str "Nowadays users want their web app to work anywhere anytime. They want to be able to use their app even when the Internet connection is down.
       During this talk you will learn what is a progressive web app, what is PouchDB and how both allow you to create offline apps that store data in the browser and synchronize them when users are back online."
     }
    bio = Some "François's been programming for a long time using so many languages. Now he's deep into functional programming using F# and Fable for all his web and IOT projects. He also spends a lot of time with kids through coding jams and teaches IT to young adults"
    twitter = Some "thewhitetigle"
    github = Some "whitetigle"
  }

let Maxime =
  {
    shortname = "maxime"
    name = "Maxime Mangel"
    picture = "img/maxime.png"
    talk =
     { title = "Keynote - User-friendly apps start with dev-friendly tools"
       content = str "As developers we use libraries every day to make our lives easier, but sometimes learning how to use them becomes more complex than the task they're supposed to solve. During this talk I will share my experience creating libraries for the Fable ecosystem, as well as some advice to design and evolve user-friendly APIs."
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
        content = str "Over the last few years, developments in the F# web programming space has been really interesting - raise of the Fable, Giraffe, Saturn and SAFE stack has opened new opportunities for F# developers. But there is even more excitement on the horizon... let's boldly go where no talk has gone before!"
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
      { title = "Becoming a full stack developer: a quest into the unknown"
        content = str "A lot of developers, including myself, believe that a full stack developer is a myth. But front-end development has changed a lot and the introduction of Babel and Elm have pushed it in a new direction. So it is time to reinvestigate if it is possible to be one.
        In this talk I will share my experience with getting back into front-end development, more specifically the Fable ecosystem, after leaving it behind for a long time: how creating a front-end is different from creating a back-end, which parts of learning it was easy and which parts were hard and how thinking about code aesthetics changes the way you write code in general."
      }
    bio = Some "Gien is a software developer with 8 years of experience, mainly in a .NET environment. She is a strong believer of continuously learning by deliberate practice and knowledge sharing, which is why she takes part in the organization of two Belgian communities, namely DDDBE and SoCraTesBE."
    twitter = Some "selketjah"
    github = Some "selketjah"
  }

let Sia =
  {
    shortname = "sia"
    name = "Sia"
    picture = "img/Sia.jpg"
    talk =
      { title = "Azure Functions Deep Dive"
        content = str """Serverless is a great architecture and it helps saving costs and building more reliable and scalable services.
Azure functions, the serverless implementation within Azure, is now around for quite sometime and latley it's getting a lot of attention. But how does azure functions look like under the hood? What is the engine behind azure functions and how can we debug the function host, if needed?
In this session, we'll get some deeper insights into azure functions and get some hints about how to debug and get started to contribute to the project."""
      }
    bio = None
    twitter = Some "DerSia_"
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

let Janek =
  {
    shortname = "janekf"
    name = "Jan Fellien"
    picture = "img/janekf.png"
    talk =
      { title = "Azure Functions - Microsoft's Glue in Serverless Architectures"
        content = str "I'm quite sure you already heard a lot about Serverless Computing the next evolution of Software Development. Maybe you tried a bit or flirt with thoughts to use it for next feature implementation. Be sure it's harder than expected. Since 2016 I'm deep in Azure Functions, Microsofts answer to AWS Lambda. Also I'm deep in Serverless Architectures in an Azure environment. In many times I'm trapped, but it is fine for me. I've learned a lot which I want to share in this talk."
      }
    bio = Some """My current number of life: 26111.4. Software Developer for 26 years, on the road as Rebel at Work for 11 years and Microsoft MVP since first of April 2018.
I love Domain Driven Design (DDD) as a method for modelling the right thing and implementation by the CQRS philosophy. But also I love Serverless Technologies because I have implemented enough infrastructure in my life.
I'm organizer of the first German DDD conference KanDDDinsky and deeply involved in activities of Germans Developer Communities."""
    twitter = Some "janekf"
    github = Some "jfellien"
  }

let Julien =
  {
    shortname = "julien"
    name = "Julien Roncaglia"
    picture = "img/Julien.jpg"
    talk =
      { title = "React performance in a Fable world"
        content = str "Whenever directly or via Elmish as a Fable developper React is a big part of the story. This talk will explain how the main React mechanisms works and show how to use them to produce performant applications."
      }
    bio = Some "Julien is a French developer with interests spanning system level programming to functionnal on the .NET stack. He is currently focusing on F#, DevOps and performance."
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
        content = str "Understanding the techniques of building large Elmish applications by example, we will go through the process of breaking down our code into small, isolated, pieces which we will then wire together to make up the whole application."
      }
    bio = Some "Zaid is a software developer who is a life-long learner and very passionate about programming, started as a hobby and later became an addiction thanks to OSS, mainly involved with the F# and Fable community. "
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


let Hackspace =
  {
    shortname = "hackspace"
    name = "Hackspace"
    picture = "img/Mystery.png"
    talk =
      { title = "Hackspace"
        content = str "You decide what to do! Grab the opportunity of being together with so many OSS contributors to discuss ideas and hack code together. Maybe the next big F# project will start here?"
      }
    bio = None
    twitter = None
    github = None
  }

let Stachu =
  {
    shortname = "stachu"
    name = "Stachu Korick"
    picture = "img/Stachu.jpg"
    talk =
      { title = "Solving Puzzles, Functionally"
        content = str """Learn how to use F# and Fable to solve the Rubik's Cube. We will briefly introduce the history of the puzzle and model the relevant domain, forming a common language and understanding. Then we will iterate through methods of solving, from naive brute-force approaches to heuristic-driven methods that take advantage of multiple processors."""
      }
    bio = Some """Formerly an active member of the Rubik's Cube speed-solving community, Stachu loves solving problems and follows the cubing adage "Go Slow and Look Ahead" to the best of his ability."""
    twitter = Some "StachuDotNet"
    github = Some "StachuDotNet"
  }



let Anthony =
  {
    shortname = "anthony"
    name = "Anthony Brown"
    picture = "img/Anthony.jpg"
    talk =
      { title = "SAFE-Stack dojo"
        content = str "This workshop is designed to allow you to experience the SAFE-Stack based on an ready-made application that you can build on top of. It will take around 90 minutes for you to complete if you have no experience in any of these technologies."
      }
    bio = Some "Anthony is a consultant at Compositional IT where he helps organisations solve problems using F# and Azure."
    twitter = Some "bruinbrown93"
    github = Some "bruinbrown"
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

let Tomasp =
  {
    shortname = "tomasp"
    name = "Tomas Petricek"
    picture = "img/Tomasp.jpg"
    talk =
      { title = "Build your own Excel 365 in an hour (or so)"
        content = str "There are many interesting things happening in a spreadsheet. It needs an interactive user interface where users can edit data and formulas in cells, it needs to parse formulas that users write, it needs to evaluate formulas and show results on the fly and it also needs to handle errors such as division by zero and circular references. In this workshop you'll learn how to do all this using the Elm architecture, together with tips and tricks for handling the errors you may encounter on the way."
      }
    bio = Some "Tomas is a computer scientist, book author and open-source developer. He wrote a popular book called \"Real-World Functional Programming\" and is a lead developer of several F# open-source libraries, but he also contributed to the design of the F# language as an intern and consultant at Microsoft Research. He is a partner at fsharpWorks where he provides trainings and consulting services. Tomas recently submitted his PhD thesis at the University of Cambridge focused on types for understanding context usage in programming languages, but his most recent work also includes two essays that attempt to understand programming through the perspective of philosophy of science."
    twitter = Some "tomaspetricek"
    github = Some "tpetricek"
  }

let Dag =
  {
    shortname = "dag"
    name = "Dag Brattli"
    picture = "img/Dag.jpg"
    talk =
      { title = "Hands-on Fable Reaction"
        content = str "Fable Reaction combines the power of reactive programming with the Elmish message stream. In this workshop you will learn how you easily can modify an Elmish application to transform, filter, time-shift and combine keyboard, mouse and websocket events."
      }
    bio = Some "Dag Brattli works as a software developer at Serit IT Partner in Norway, a consultant company that uses only F# for software development. He is the creator of the Reactive Extensions for Python (RxPY) and AioReactive (async/await reactive tools for Python). In his previous life he also worked on several prosjects using RxJS and Rx.NET. Meeting the amazing world of Fable and Elmish resulted in the newest creation called Fable Reaction."
    twitter = Some "dbrattli"
    github = Some "dbrattli"
  }
