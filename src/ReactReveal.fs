module ReactReveal

open Fable.Core
open Fable.React
open Fable.Core.JsInterop

let inline zoom (props: obj seq) (elems : ReactElement list) : ReactElement =
    ofImport "Zoom" "react-reveal" props elems

let inline fade (props : obj seq) (elems : ReactElement list) : ReactElement =
    ofImport "Fade" "react-reveal" props elems    