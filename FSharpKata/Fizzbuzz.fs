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

let (<+>) switch1 switch2 x =
    match (switch1 x), (switch2 x) with
    | Carbonated s1,Carbonated s2 -> carbonated (s1 + s2)
    | Uncarbonated f1,Carbonated s2  -> carbonated s2
    | Carbonated s1,Uncarbonated f2 -> carbonated s1
    | Uncarbonated f1,Uncarbonated f2 -> uncarbonated f1

let Fizzbuzz =
    let carbonateAll = 
        carbonate 3 "Fizz" <+> carbonate 5 "Buzz"
    
    carbonateAll
    >> either (fun f -> f.ToString()) (fun f1 -> f1)