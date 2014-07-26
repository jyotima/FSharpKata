module Fizzbuzz

// http://fsharpforfunandprofit.com/posts/railway-oriented-programming-carbonated/

let (|Uncarbonated|Carbonated|) =
    function
    | Choice1Of2 u -> Uncarbonated u
    | Choice2Of2 c -> Carbonated c

let uncarbonated x = Choice1Of2 x
let carbonated x = Choice2Of2 x

let either successfulFunc failureFunc twoTrackInput =
    match twoTrackInput with
    | Uncarbonated s -> successfulFunc s
    | Carbonated f -> failureFunc f

let bind f = 
    either f carbonated

let carbonate factor label i = 
        if i % factor = 0 then
            carbonated label
        else
            uncarbonated i

let Fizzbuzz =
    carbonate 15 "FizzBuzz"
    >> bind (carbonate 3 "Fizz")
    >> bind (carbonate 5 "Buzz")
    >> either (fun f -> f.ToString()) (fun f1 -> f1)