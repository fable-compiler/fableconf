module Speakers

open Types
open Fable.React

type Model =
  { modal: (Speaker * Talk) option
    speakers: Speaker list }

let Alfonso =
  {
    shortname = "Alfonso"
    name = "Alfonso García-Caro"
    picture = "img/Alfonso.jpeg"
    bio = Some """A linguist by heart and a programmer by choice, Alfonso has brought his passion for natural languages to the computing world. He is the creator of Fable, a popular F# to JS compiler, and coauthor of the book "Mastering F#". Currently works as a web engineer using F# and Fable for highly productive and reliable software development."""
    twitter = Some "alfonsogcnunez"
    github = Some "alfonsogarciacaro"
    links = []
  }

let François =
  {
    shortname = "francois"
    name = "François Nicaise"
    picture = "img/François.jpg"
    bio = Some "I have been using F# and Fable in all my projects since 2017. I feel just like Rick Dangerous... But here, it's so safe, there aren't any traps."
    twitter = Some "thewhitetigle"
    github = Some "whitetigle"
    links = []
  }

let Maxime =
  {
    shortname = "maxime"
    name = "Maxime Mangel"
    picture = "img/maxime.png"
    bio = Some "Maxime's has been testing a lot of languages over the past 10 years. Finally, he stopped with F# thanks to Fable discovery. He is working at Fleet Performance on a monitoring solution for mining quarry."
    twitter = Some "MangelMaxime"
    github = Some "MangelMaxime"
    links = []
  }


let Krzysztof =
  {
    shortname = "krzysztof"
    name = "Krzysztof Cieślak"
    picture = "img/Krzysztof.jpg"
    bio = Some "Krzysztof is a software developer, consultant, open source contributor and active member of the F# community."
    twitter = Some "k_cieslak"
    github = Some "Krzysztof-Cieslak"
    links = []
  }

let Gien =
  {
    shortname = "gien"
    name = "Gien Verschatse"
    picture = "img/Gien.jpg"
    bio = Some "Gien is a software developer with 8 years of experience, mainly in a .NET environment. She is a strong believer of continuously learning by deliberate practice and knowledge sharing, which is why she takes part in the organization of two Belgian communities, namely DDDBE and SoCraTesBE."
    twitter = Some "selketjah"
    github = Some "selketjah"
    links = []
  }

let Sia =
  {
    shortname = "sia"
    name = "Sia"
    picture = "img/Sia.jpg"
    bio = None
    twitter = Some "DerSia_"
    github = None
    links = []
  }

let Evelina =
  {
    shortname = "evelina"
    name = "Evelina Gabasova"
    picture = "img/Evelina.jpg"
    bio = Some "Evelina is a machine learning researcher working in bioinformatics, trying to reverse-engineer cancer at University of Cambridge. When not at work, she likes to play with fun datasets to extract interesting insights."
    twitter = Some "evelgab"
    github = Some "evelinag"
    links = []
  }

let Janek =
  {
    shortname = "janekf"
    name = "Jan Fellien"
    picture = "img/janekf.jpg"
    bio = Some """My current number of life: 26111.4. Software Developer for 26 years, on the road as Rebel at Work for 11 years and Microsoft MVP since first of April 2018.
I love Domain Driven Design (DDD) as a method for modelling the right thing and implementation by the CQRS philosophy. But also I love Serverless Technologies because I have implemented enough infrastructure in my life.
I'm organizer of the first German DDD conference KanDDDinsky and deeply involved in activities of Germans Developer Communities."""
    twitter = Some "janekf"
    github = Some "jfellien"
    links = []
  }

let Julien =
  {
    shortname = "julien"
    name = "Julien Roncaglia"
    picture = "img/Julien.jpg"
    bio = Some "Julien is a French developer with interests spanning system level programming to functional on the .NET stack. He is currently focusing on F#, DevOps and performance."
    twitter = Some "virtualblackfox"
    github = Some "vbfox"
    links = []
  }

let Diego =
  {
    shortname = "diego"
    name = "Diego Esmerio"
    picture = "img/Mistery.jpg"
    bio = None
    twitter = None
    github = None
    links = []
  }

let Tomasz =
  {
    shortname = "tomasz"
    name = "Tomasz Heimowski"
    picture = "img/Tomasz.jpg"
    bio = Some "Tomasz is a passionate developer whose main areas of interest are F# and Functional Programming in general. As a Senior Software Engineer at Datto he tackles problems from various domains. In his free time, apart from contributing to OSS projects and learning new tech stuff, he enjoys lifting weights as well as dancing."
    twitter = Some "theimowski"
    github = Some "theimowski"
    links = []
  }

let RomanP =
  {
    shortname = "romanp"
    name = "Roman Provazník"
    picture = "img/RomanP.jpg"
    bio = Some "Roman is the founder of a Czech F# community called FSharping, who works in CN Group as an F# team leader. You can find him mostly in a good mood and ready to chat about the things he loves: F#, functional programming, domain-driven design, event sourcing systems, web development and drums."
    twitter = Some "rprovaznik"
    github = Some "dzoukr"
    links = []
  }

let Zaid =
  {
    shortname = "zaid"
    name = "Zaid Ajaj"
    picture = "img/Zaid.jpg"
    bio = Some "Zaid is a software developer who is a life-long learner and very passionate about programming, started as a hobby and later became an addiction thanks to OSS, mainly involved with the F# and Fable community. "
    twitter = Some "zaid_ajaj"
    github = Some "Zaid-Ajaj"
    links = []
  }

let RomanS =
  {
    shortname = "romans"
    name = "Roman Sachse"
    picture = "img/RomanS.jpg"
    bio = Some "Roman Sachse started programming 16 years ago rather by accident shortly after founding his first company when he realized how much fun it was building the stuff he was working on by himself. This set him out on a lifelong journey of learning everything about software development and computer science and he was particularly surprised to realize that this branch of science strongly depends on two fields he was always interested in: people and communication. Roman is a proud father of three year old twin girls, holds a bachelors degree in Cognitive Science and a Masters degree in Computer Science and is currently mainly interested in Domain Driven Design, Functional Programming and the inner workings of software development teams."
    twitter = Some "R0MMSEN"
    github = Some "rommsen"
    links = []
  }

let TBD =
  {
    shortname = "tbd"
    name = "TBD"
    picture = "img/Mystery.jpg"
    bio = None
    twitter = None
    github = None
    links = []
  }

let Stachu =
  {
    shortname = "stachu"
    name = "Stachu Korick"
    picture = "img/Stachu.jpg"
    bio = Some """Formerly an active member of the Rubik's Cube speed-solving community, Stachu loves solving problems and follows the cubing adage "Go Slow and Look Ahead" to the best of his ability."""
    twitter = Some "StachuDotNet"
    github = Some "StachuDotNet"
    links = []
  }


let Anthony =
  {
    shortname = "anthony"
    name = "Anthony Brown"
    picture = "img/Anthony.jpg"
    bio = Some "Anthony is a consultant at Compositional IT where he helps organisations solve problems using F# and Azure."
    twitter = Some "bruinbrown93"
    github = Some "bruinbrown"
    links = []
  }

let Steffen =
  {
    shortname = "steffen"
    name = "Steffen Forkmann"
    picture = "img/Steffen.jpg"
    bio = Some "Steffen Forkmann works as a Software Developer on large billing systems and therefore has great experience in applying functional concepts to real-world applications. Steffen is a very active part in the F# open source community and works on many OSS projects like FAKE - F# Make, Paket and the F# compiler."
    twitter = Some "sforkmann"
    github = Some "forki"
    links = []
  }

let Tomasp =
  {
    shortname = "tomasp"
    name = "Tomas Petricek"
    picture = "img/Tomasp.jpg"
    bio = Some "Tomas is a computer scientist, book author and open-source developer. He wrote a popular book called \"Real-World Functional Programming\" and is a lead developer of several F# open-source libraries, but he also contributed to the design of the F# language as an intern and consultant at Microsoft Research. He is a partner at fsharpWorks where he provides trainings and consulting services. Tomas recently submitted his PhD thesis at the University of Cambridge focused on types for understanding context usage in programming languages, but his most recent work also includes two essays that attempt to understand programming through the perspective of philosophy of science."
    twitter = Some "tomaspetricek"
    github = Some "tpetricek"
    links = []
  }

let Dag =
  {
    shortname = "dag"
    name = "Dag Brattli"
    picture = "img/Dag.jpeg"
    bio = Some "Dag Brattli works as an R&D engineer at Cognite in Norway. He is the creator of the Reactive Extensions for Python (RxPY). In his previous life he also worked on several prosjects using RxJS and Rx.NET. Meeting the amazing world of Fable and Elmish resulted in the newest creation called Fable Reaction."
    twitter = Some "dbrattli"
    github = Some "dbrattli"
    links = []
  }

let Vagif =
  {
    shortname = "vagif"
    name = "Vagif Abilov"
    picture = "img/Vagif.png"
    bio = Some "Vagif Abilov is a Russian/Norwegian software developer and architect working for Miles. He has several decades of programming experience that includes various programming languages, currently using mostly C# and F#. Vagif writes articles and speaks (and sometimes sings) at user group sessions and conferences."
    twitter = Some "ooobject"
    github = Some "object"
    links = []
  }

let Joerg =
  {
    shortname = "joerg"
    name = "Joerg Beekmann"
    picture = "img/Mistery.jpg"
    bio = None
    twitter = Some "jbeeko"
    github = None
    links = []
  }

let Colin =
  {
    shortname = "colin"
    name = "Colin Gravill"
    picture = "https://pbs.twimg.com/profile_images/1105163203783348225/ZDySxIq6_400x400.png"
    bio = Some """I'm a software developer at Microsoft Research. My group works on Biological Computation where we try to reprogram biology with domain-specific languages, robotic automation, and a lot of computation!"""
    twitter = Some "CGravill"
    github = Some "cgravill"
    links = ["Microsoft Biological Computation", "https://www.microsoft.com/en-us/research/group/biological-computation/"]
  }

let Brett =
  {
    shortname = "brett"
    name = "Brett Rowberry"
    picture = "img/Brett.jpg"
    bio = Some """I’ve been doing enterprise .NET development since 2016 and F# found me through a C# course on Pluralsight. I live in Houston with my beautiful wife and energetic son."""
    twitter = Some "BrettRowberry"
    github = Some "brettrowberry"
    links = []
  }

let Georg =
  {
    shortname = "georg"
    name = "Georg Haaser"
    picture = "img/Georg.jpg"
    bio = Some """I'm a researcher at the VRVis Research Center in Vienna for 10 years now, interested in Computer Graphics, Compilers, Functional Programming, Geometry and generally solving formal Problems.
Over the last years I spent most of my time implementing/improving our research renderer/platform in F#.
Recently me and some friends founded Aardworx, a company aimed at creating high performance software for problems in the field of computer graphics.
In my free time I enjoy hiking and generally spending time in nature."""
    twitter = None
    github = Some "krauthaufen"
    links = []
  }


let Florian =
  {
    shortname = "florian"
    name = "Florian Verdonck"
    picture = "img/Florian.jpg"
    bio = Some """Florian is a passionate young .NET consultant at Axxes.
With a love for functional programming, he contributes to open-source projects and tries to be active in the community."""
    twitter = Some "verdonckflorian"
    github = Some "nojaf"
    links = ["Axxes", "https://axxes.com/en"
             "Blog", "https://blog.nojaf.com"]
  }
