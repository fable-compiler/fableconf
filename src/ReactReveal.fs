module ReactReveal

open Fable.Core
open Fable.React
open Fable.Core.JsInterop

type ZoomProps =
  | Percent of int
  | StrokeWidth of int
  | StrokeColor of string

let inline zoom (props: obj seq) (elems : ReactElement list) : ReactElement =
    ofImport "Zoom" "react-reveal" props elems

let inline fade (props : obj seq) (elems : ReactElement list) : ReactElement =
    ofImport "Fade" "react-reveal" props elems    