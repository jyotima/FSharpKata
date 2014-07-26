module Fizzbuzz

// http://fsharpforfunandprofit.com/posts/railway-oriented-programming-carbonated/

let (|Success|Failure|) =
    function
    | Choice1Of2 s -> Success s
    | Choice2Of2 f -> Failure f

let succeed x = Choice1Of2 x
let fail x = Choice2Of2 x

let either successfulFunc failureFunc twoTrackInput =
    match twoTrackInput with
    | Success s -> successfulFunc s
    | Failure f -> failureFunc f

let bind f = 
    either f fail

let carbonate factor label i = 
        if i % factor = 0 then
            fail label
        else
            succeed i

let Fizzbuzz =
    carbonate 15 "FizzBuzz"
    >> bind (carbonate 3 "Fizz")
    >> bind (carbonate 5 "Buzz")
    >> either (fun f -> f.ToString()) (fun f1 -> f1)