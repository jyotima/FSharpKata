module Fizzbuzz

// http://fsharpforfunandprofit.com/posts/railway-oriented-programming-carbonated/

let Fizzbuzz number = 
    let mutable printed = false
    if number % 3 = 0 then
        printed <- true
        printf "Fizz"
    if number % 5 = 0 then 
        printed <- true
        printf "Buzz"

    if not printed then
        printf "%i" number