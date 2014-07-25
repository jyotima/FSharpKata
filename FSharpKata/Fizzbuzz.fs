module Fizzbuzz

// http://fsharpforfunandprofit.com/posts/railway-oriented-programming-carbonated/

let carbonate factor label data =
    let (i, labelSoFar) = data
    if i % factor = 0 then 
        let newLabel =
            labelSoFar
            |> Option.map (fun s -> s + label)
            |> defaultArg <| label
        (i, Some newLabel)
    else
        data

let labelOrDefault data = 
    let (i : int, labelSoFar) = data
    labelSoFar
    |> defaultArg <| i.ToString()
    

let FizzBuzzWithRules rules number =
    let allRules =
        rules
        |> List.map( fun (factor, label) -> carbonate factor label)
        |> List.reduce(>>)

    (number, None)
    |> allRules
    |> labelOrDefault

let Fizzbuzz number = 
    let rules = [ (3,"Fizz"); (5,"Buzz"); ]
    FizzBuzzWithRules rules number
    