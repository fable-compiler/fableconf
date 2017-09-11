module Speakers.State

open Elmish
open Types

let shuffle (org:_ list) =
    let rng = System.Random()
    let arr = Array.ofList org
    let max = arr.Length - 1
    let randomSwap (arr:_[]) i =
        let pos = rng.Next(max)
        let tmp = arr.[pos]
        arr.[pos] <- arr.[i]
        arr.[i] <- tmp
        arr
    [|0..max|] |> Array.fold randomSwap arr |> Array.toList

let init () : Model =
  let speakers =
    [ Eugene
      François
      Maxime
      Indy
      Sven
      Alfonso
      Krzysztof ]
  { modal = None; speakers = shuffle speakers }
