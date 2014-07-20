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
open Xunit.Extensions


[<Fact>]
let AddShouldReturn0OnEmptyNumber() =
    add "" |> should equal 0

[<Theory>]
[<InlineData("1", 1)>]
[<InlineData("2", 2)>]
[<InlineData("3", 3)>]
let AddShouldReturnNumberIfASingleNumberIsPassed number expected =
    add number |> should equal expected

[<Fact>]
let AddShouldReturnAdditionOfTwoNumbers() =
    add "1,2" |> should equal 3