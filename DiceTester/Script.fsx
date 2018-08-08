#load "Dice.fs"
#load "DnD5e.fs"
#load "Distribution.fs"

open DiceTester
open Distribution
open Dice
open DnD5e

// Define your library scripting code here
let Prova v : int =
    match v with
    | 0 -> 0
    | v when v <= 6 -> v
    | x -> 0

let Cazzo (c: int) =
    float c