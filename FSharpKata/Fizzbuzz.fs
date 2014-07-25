module Fizzbuzz

// http://fsharpforfunandprofit.com/posts/railway-oriented-programming-carbonated/

type Data = {i:int; label:string option}

let carbonate factor label data =
    let {i = i; label = labelSoFar} = data
    if i % factor = 0 then 
        let newLabel =
            match labelSoFar with
            | Some s -> s + label
            | None -> label
        {data with label = Some newLabel}
    else
        data

let labelOrDefault data = 
    let { i = i; label = labelSoFar} = data
    match labelSoFar with
    | Some s -> s
    | None -> i.ToString()

let Fizzbuzz number = 
    // FizzBuzzWithRules number
    {i = number; label = None}
    |> carbonate 3 "Fizz"
    |> carbonate 5 "Buzz"
    |> labelOrDefault