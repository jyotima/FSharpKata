module StringCalculatorTests

// AddShouldReturn0OnEmptyNumber
// AddShouldReturnNumberIfSingleNumberIsPassed
// AddShouldReturnAdditionOfNumbersIfTwoNumbersArePassed
// AddShouldReturnAdditionOfNumbersIfNewLineDelimiterIsPassed
// AddShouldReturnAdditionOfNumbersIfMultipleNumbersArePassed
// AddShouldReturnAdditionOfNumbersIfCustomDelimitersArePassed
// AddShouldThrowIfNegative NumbersArePassed

open StringCalculator
open Xunit
open FsUnit.Xunit


[<Fact>]
let AddShouldReturn0OnEmptyNumber() =
    add "" |> should equal 0

[<Fact>]
let AddShouldReturnNumberIfASingleNumberIsPassed() =
    add "1" |> should equal 1