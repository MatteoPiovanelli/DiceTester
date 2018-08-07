#load "DiceTester.fs"
open DiceTester
open dnd5e

// Define your library scripting code here
let printAC low high =
    printfn "AC"
    let acs = dnd5e.acRange low high
    printfn "%A" (acs |> List.take (1 + high - low))