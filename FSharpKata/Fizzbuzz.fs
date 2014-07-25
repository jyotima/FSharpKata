module Fizzbuzz

// http://fsharpforfunandprofit.com/posts/railway-oriented-programming-carbonated/

let FizzBuzzWithRules number = 
    let rules = [(3, "Fizz") ; (5, "Buzz")]
    let mutable printed = false
    let mutable returnLabel = ""
    for factor, label in rules do
        if number % factor = 0 then
            printed <- true
            returnLabel <- returnLabel + label
    
    if not printed then
        number.ToString()
    else returnLabel

let Fizzbuzz number = 
    FizzBuzzWithRules number