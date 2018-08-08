#load "DiceTester.fs"
open DiceTester
open dnd5e

// Define your library scripting code here
let Prova v : int =
    match v with
    | 0 -> 0
    | v when v <= 6 -> v
    | x -> 0

let Cazzo (c: int) =
    float c