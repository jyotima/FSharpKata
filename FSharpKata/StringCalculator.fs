module StringCalculator

open System

let add number = 
    match number with
    | n when String.IsNullOrEmpty(n) -> 0
    | _ -> Int32.Parse(number) 
