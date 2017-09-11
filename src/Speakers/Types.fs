module Speakers.Types

open Fable.Import.React
open Fable.Helpers.React
open Fable.Helpers.React.Props

type Talk =
  { title: string; content: ReactElement }

type Speaker =
  {
    shortname: string
    name: string
    picture: string
    talk: Talk
    bio: string option
    twitter: string option
    github: string option
  }

type Model =
  { modal: (Speaker * Talk) option
    speakers: Speaker list }

let Eugene =
  {
    shortname = "eugene"
    name = "Eugene Tolmachev"
    picture = "img/Eugene.png"
    talk =
     { title = "Elmish: the foundation your Web or Native applications deserve"
       content =
        div [] [
          p [] [str "Elmish has become known as a way for building UIs with React and React Native, but the reason it was developed was to provide a solid foundation for event-driven applications running on the client. We program for an increasingly connected world and most APIs we'll call will be asynchronous. Discover how elmish streams data from callbacks, promises, successes and failures by representing them as a Message. Whether they are generated internally, by the user or came from a websocket they are all routed to the analytical core of your application."]
          p [] [
            str "Learn more at "
            a [Href "https://fable-elmish.github.io/"] [str "Fable.Elmish site"]
            str "."
          ]
        ] }
    bio = Some "Eugene's has been programming for over 20 years and finally found his way to F# and Fable. He's F#unctional Toronto organizer, a Novell alumni and a veteran of several startups, presently working at Prolucid on scalable and fault-tolerant systems."
    twitter = None
    github = Some "et1975"
  }

let François =
  {
    shortname = "francois"
    name = "François Nicaise"
    picture = "img/François.jpg"
    talk =
     { title = "Fable for busy dads: how Fable helps me to spend more time with my children"
       content =
        div [] [
          p [] [
            str "Fable's motto could be: "
            strong [] [str "if it compiles then it works."]
          ]
          p [] [str "As a freelancer, using a functional language in Creepy Mutable Land just allows me to code faster, to release sooner and of course, to avoid running after runtime errors."]
          p [] [str "With 3 kids, 2 cats and 3 chicken at home I just don't want to spend time on strange runtime errors creeping from mutable underworld. And if I want to remain competitive, the only errors I can accept are logical ones coming from my own nasty code and CSS compatibility junk."]
          p [] [str "But JS is everywhere. And while the language has thousands problems, the JS ecosystem is just awesome. So why stick with JS when I can use F#?"]
          ul [] [
            li [] [str "I need to ship things early with NO bugs."]
            li [] [str "I need to understand my code when adding features months later."]
            li [] [str "I need my business logic to flow naturally from my mind to the code sheet."]
            li [] [str "I need to be able to plug in any JS libs needed whithout worrying about side effects on my project."]
            li [] [str "I want to be able to get started in a few seconds"]
            li [] [str "I want live reloads while I'm coding"]
            li [] [str "I want to code JS apps with real completion, syntax errors highlighting, refactoring enabled"]
            li [] [str "I need to be productive and..."]
          ]
          em [] [str "I just want to spend time reading stories to my kids and sleep at night."]
        ]
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
     { title = "Hink: Write Web applications without CSS"
       content =
        div [] [
          p [] [str "Hink, is a library allowing developers to write web application without CSS. It's primary goal is to provide the basics stack needed to create an UI."]
          p [] [str "We will talk about how Fable has been used to create a library as Hink (benefit of mixing OOP and functional design). And see how Hink can be used to prototype application."]
          img [Src "img/hink.gif"]
        ]
     }
    bio = Some "Maxime's has been testing a lot of languages over the past 10 years. Finally, he stopped with F# thanks to Fable discovery. He is working at Fleet Performance on a monitoring solution for mining quarry."
    twitter = Some "MangelMaxime"
    github = Some "MangelMaxime"
  }

let Indy =
  {
    shortname = "indy"
    name = "Indy M."
    picture = "img/Indy.jpeg"
    talk =
      { title = "Thinking Feeling Acting agents - Train an AI spacecraft to explore in your browser"
        content = str "We will look at how to train an Recurrent Neural Network based agent (spacecraft) to navigate a simulated asteroid field. Unlike the game playing Deep Learning methods that use the screen pixels as the input, our agent is situated in the environment that it is acting in. It sees the world around it using its sensors. It decides where to look and what to pay attention to. It decides when to use the thrusters to move but it has to conserve its limited fuel. We will look at how to use evolutionary strategies to train these and a bit of philosophical view of what AI is and can be."}
    bio = Some "Indy is the lead architect at heyolly.com ambitiously creating a robot with personality, which learns from users' actions and behaviours. Previously was at Microsoft Research Cambridge where he created large scale machine learning infrastructure with F# and contributed to medical image analysis research among other things."
    twitter = Some "indy9000"
    github = Some "Indy9000"
  }

let Sven =
  {
    shortname = "sven"
    name = "Sven Sauleau"
    picture = "img/Sven.jpeg"
    talk =
      { title = "Behind the scenes of Fable: Babel"
        content = str "We will have a look at Fable behind the scene, demystifying how you end up with JavaScript, and exposing the role of Babel in our ecosystem. Integration with the JavaScript environment is one of the key points of Fable, I will show you different tools to achieve that and in bonus, some optimizations/tricks." }
    bio = Some "Member of the Babel maintainers. Passionated by functional programming, distributed systems or compilers."
    twitter = Some "svensauleau"
    github = Some "xtuc"
  }

let Alfonso =
  {
    shortname = "alfonso"
    name = "Alfonso García-Caro"
    picture = "img/Alfonso.jpeg"
    talk =
     { title = "Towards a new way of collaboration"
       content =
        div [] [
          p [] [str "Fable, Babel and many other open source projects are just examples of the magic that happens when people all over the world start collaborating together. Today, someone has an idea and posts a prototype, then thousand of miles away another one likes it and starts collaborating, then users come in and contribute valuable feedback and suggestion, making the project better and better. All of this happened thanks to sites like Github which removed the barriers from coding alone to coding in public."]
          p [] [str "However, for the most part it's only us programmers who are invited to the party. If we really want to change the world, we need to bring in experts from other disciplines: Economy, Medicine, Architecture... And we can only achieve this by tearing down the remaining barriers for programming collaboration:"]
          ul [] [
            li [] [str "Contributors should be able to start editing the program and see the results online"]
            li [] [str "Contributors should have tools to help them: autocompletion, validation..."]
            li [] [str "Contributors should not need to know a programming language. Domain-specific problems must be resolved with simple domain-specific languages (DSL)"]
            li [] [str "Everybody should be able to embed this kind of environment in their websites and let run everything in the browser"]
          ]
          p [] [
            str "Fable brings together the dynamicity of JavaScript to run code live on the web, and the expressiveness of F# to create a custom DSL and easily communicate with domain experts. Inspired by "
            a [Href "https://thegamma.net/"] [str "the Gamma Project"]
            str ", in this talk we'll see how to write an algorithm for Economic simulations and let non-programmers edit it online to share their findings and achieve our goal together."
          ]
          p [] [str "Will this be the start of a new way of collaboration in the web? Come to FableConf and let's find it out together!"]
        ]
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
      { title = "Building editor tooling with Fable"
        content =
          div [] [
            p [] [str "One of the Fable aims is to bring happiness, create ecosystem that's easy and fun to use. Such ecosystem consists of not only great compiler (and Fable is great), and good libraries (and we have some amazing libraries) but it also needs to includes great tooling around it."]
            p [] [str "In the talk I'll show how Fable enables us to easily create rich editor tooling in VSCode (lightweight, cross platform IDE) and Monaco ( online editor). It will be based on over a year of experience of using Fable 'in production' to create Ionide - F# tooling in VSCode, and Ionide-web - online editor for F#"]
          ]
      }
    bio = Some "Krzysztof is an software developer, consultant, open source contributor and active member of the F# community."
    twitter = Some "k_cieslak"
    github = Some "Krzysztof-Cieslak"
  }

let speakersMap =
  [ Eugene.shortname, Eugene
    François.shortname, François
    Maxime.shortname, Maxime
    Sven.shortname, Sven
    Indy.shortname, Indy
    Alfonso.shortname, Alfonso
    Krzysztof.shortname, Krzysztof
  ] |> Map

