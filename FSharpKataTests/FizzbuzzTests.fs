module FizzbuzzTests

open Fizzbuzz
open FsUnit
open Xunit.Extensions
open Xunit
open FsUnit.Xunit

[<Theory>]
[<InlineData(1, "1")>]
let FizzBuzzReturnsCorrectResult number expected = 
    number
    |> Fizzbuzz
    |> should equal expected