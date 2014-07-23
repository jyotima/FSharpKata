module StringCalculator

open System
open System.Linq

let getValuesAndSeparator (number : string)=
    match number with
    | n when n.StartsWith("//") ->
       let delimiter = [|number.ElementAt(2)|]
       let number1 = number.Substring(3)
       number1, delimiter
    | _ ->
       let delimiter = [|',';'\n'|]
       number, delimiter

let getValues (number : string) = 
    let values, separator = getValuesAndSeparator number
    values.Split(separator).Select(fun f -> Int32.Parse(f))

let add number =
    match number with
    | n when String.IsNullOrEmpty(n) -> Some(0)
    | _ ->  
            let parsedInts = getValues number
            let negativeInts = parsedInts.Where(fun f -> f < 0)
            match negativeInts with
            | i when i.Any() -> None
            | _ -> Some(parsedInts.Sum())