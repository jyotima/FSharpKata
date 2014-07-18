module FSharpKata

open Fizzbuzz
[<EntryPoint>]
let main args =
    [1..100]
    |> List.map Fizzbuzz
    |> List.map (printf "%s\r\n")
    |> ignore
    0