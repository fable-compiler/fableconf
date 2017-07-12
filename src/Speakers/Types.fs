module Speakers.Types

open Fable.Import.React
open Fable.Helpers.React

type Talk =
  { title: string; content: ReactElement }

type Speaker =
  {
    name: string
    picture: string
    talk: Talk option
    bio: string option
    twitter: string option
    github: string option
  }

type Model =
  { modal: (Speaker * Talk) option
    speakers: Speaker list }

type Msg =
  | OpenModal of Speaker * Talk
  | CloseModal

let Eugene =
  {
    name = "Eugene Tolmachev"
    picture = "img/Eugene.png"
    talk = Some {
      title = "Elmish: the foundation your Web or Native applications deserve"
      content = str "Elmish has become known as a way for building UIs with React and React Native, but the reason it was developed was to provide a solid foundation for event-driven applications running on the client. We program for an increasingly connected world and most APIs we'll call will be asynchronous. Discover how elmish streams data from callbacks, promises, successes and failures by representing them as a Message. Whether they are generated internally, by the user or came from a websocket they are all routed to the analytical core of your application."
    }
    bio = Some "Eugene's has been programming for over 20 years and finally found his way to F# and Fable. He's F#unctional Toronto organizer, a Novell alumni and a veteran of several startups, presently working at Prolucid on scalable and fault-tolerant systems."
    twitter = None
    github = Some "et1975"
  }

let François =
  {
    name = "François Nicaise"
    picture = "img/François.jpg"
    talk = Some {
      title = "Fable for busy dads: how Fable helps me to spend more time with my children"
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
    name = "Maxime Mangel"
    picture = "img/maxime.png"
    talk = Some {
      title = "Hink: Write Web applications without CSS"
      content =
        div [] [
          p [] [str "Hink, is a library allowing developers to write web application without CSS. It's primary goal is to provide the basics stack needed to create an UI."]
          p [] [str "We will talk about how Fable has been used to create a library as Hink (benefit of mixing OOP and functional design). And see how Hink can be used to prototype application."]
        ]
    }
    bio = Some "Maxime's has been testing a lot of languages over the past 10 years. Finally, he stopped with F# thanks to Fable discovery. He is working at Fleet Performance on a monitoring solution for mining quarry."
    twitter = Some "MangelMaxime"
    github = Some "MangelMaxime"
  }

let Indy =
  {
    name = "Indy M."
    picture = "img/Indy.jpeg"
    talk = Some {
      title = "Thinking Feeling Acting agents - Train an AI spacecraft to explore in your browser"
      content = str "We will look at how to train an Recurrent Neural Network based agent (spacecraft) to navigate a simulated asteroid field. Unlike the game playing Deep Learning methods that use the screen pixels as the input, our agent is situated in the environment that it is acting in. It sees the world around it using its sensors. It decides where to look and what to pay attention to. It decides when to use the thrusters to move but it has to conserve its limited fuel. We will look at how to use evolutionary strategies to train these and a bit of philosophical view of what AI is and can be."
    }
    bio = Some "Indy is the lead architect at heyolly.com ambitiously creating a robot with personality, which learns from users' actions and behaviours. Previously was at Microsoft Research Cambridge where he created large scale machine learning infrastructure with F# and contributed to medical image analysis research among other things."
    twitter = Some "indy9000"
    github = Some "Indy9000"
  }

let Sven =
  {
    name = "Sven Sauleau"
    picture = "img/Sven.jpeg"
    talk = Some {
      title = "Behind the scenes of Fable: Babel"
      content = str ""
    }
    bio = None
    twitter = Some "svensauleau"
    github = Some "xtuc"
  }

let Karsten =
  {
    name = "Karsten Gebbert"
    picture = "img/Karsten.jpeg"
    talk = None
    bio = None
    twitter = Some "krstngbbrt"
    github = Some "krgn"
  }

let Alfonso =
  {
    name = "Alfonso García-Caro"
    picture = "img/Alfonso.jpeg"
    talk = None
    bio = None
    twitter = Some "alfonsogcnunez"
    github = Some "alfonsogarciacaro"
  }

let Krzysztof =
  {
    name = "Krzysztof Cieślak"
    picture = "img/Krzysztof.jpg"
    talk = None
    bio = None
    twitter = Some "k_cieslak"
    github = Some "Krzysztof-Cieslak"
  }
