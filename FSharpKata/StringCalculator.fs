module StringCalculator

open System
open System.Linq
open System.Collections.Generic

let failWithNegatives (negatives : 'int IEnumerable) =
    let message = "negative numbers are not allowed:" + String.Join(",", negatives)
    failwith message

let getSeparatorsAndValues (number : string) =
    match number with 
            | n when n.StartsWith("//") ->
                    let delimiter = [|n.ElementAt(2)|]
                    let numbers = n.Substring(3)
                    delimiter, numbers
            | _ ->  let delimiters = [|',';'\n'|]
                    delimiters, number

let getNumbers (number : string) =
    let separator, values = getSeparatorsAndValues number
    values.Split(separator)

let add number = 
    match number with
    | n when String.IsNullOrEmpty(n) -> 0
    | _ ->  let numbers = getNumbers number
            let parsedInts = numbers.Select(fun n -> Int32.Parse(n))
            let negativeInts = parsedInts.Where(fun f -> f < 0)

            match negativeInts with
            | n when n.Any() -> 
                failWithNegatives negativeInts |> ignore
                0
            | _ -> parsedInts.Sum()

// use of if else , when to use namespace and module, how to think in terms of responsibilities