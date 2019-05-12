open System

open Library

[<EntryPoint>]
let main _ =
    printfn "Individuals: %A" (getIndividuals())
    0 // return an integer exit code
