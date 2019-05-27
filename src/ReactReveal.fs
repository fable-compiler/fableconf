module ReactReveal

open Fable.Core
open Fable.React
open Fable.Core.JsInterop

let inline zoom (elems : ReactElement list) : ReactElement =
    ofImport "Zoom" "react-reveal" null elems

let inline fade (elems : ReactElement list) : ReactElement =
    ofImport "Fade" "react-reveal" null elems