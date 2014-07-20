module StringCalculator

open System
open System.Linq

let add number = 
    match number with
    | n when String.IsNullOrEmpty(n) -> 0
    | _ ->  let delimiter = [|',';'\n'|]
            number.Split(delimiter).Select(fun n -> Int32.Parse(n)).Sum()
