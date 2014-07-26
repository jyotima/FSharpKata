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

let carbonate factor label i =
    if i % factor = 0 then
        succeed label
    else fail i

let connect f =
    function
    | Success x -> succeed x
    | Failure i -> f i

let Fizzbuzz =
    carbonate 15 "FizzBuzz"
    >> connect (carbonate 3 "Fizz")
    >> connect (carbonate 5 "Buzz")
    >> either (fun f -> f) (fun f1 -> f1.ToString())