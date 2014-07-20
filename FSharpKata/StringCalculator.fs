module StringCalculator

open System
open System.Linq

let add number = 
    match number with
    | n when String.IsNullOrEmpty(n) -> 0
    | _ ->  number.Split(',').Select(fun n -> Int32.Parse(n)).Sum()
