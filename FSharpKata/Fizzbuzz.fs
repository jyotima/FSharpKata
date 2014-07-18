module Fizzbuzz

let Fizzbuzz number = 
    match number with
    | i when i % 3 = 0 && i % 5 = 0 -> "FizzBuzz"
    | i when i % 3 = 0 -> "Fizz"
    | i when i % 5 = 0 -> "Buzz"
    | _ -> number.ToString()
