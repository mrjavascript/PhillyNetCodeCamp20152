﻿// Learn more about F# at http://fsharp.net
// See the 'F# Tutorial' project for more help.

[<EntryPoint>]
let main argv = 

    let evens = List.filter(fun s -> s % 2 = 0) [1 .. 100]
    printfn "%A" evens

    printfn "%A" argv
    0 // return an integer exit code
