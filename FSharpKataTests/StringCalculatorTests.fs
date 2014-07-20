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

[<Theory>]
[<InlineData("1,2", 3)>]
[<InlineData("1,3", 4)>]
[<InlineData("1,2,3", 6)>]
[<InlineData("1,2,3,4", 10)>]
let AddShouldReturnAdditionOfMultipleNumbers number expected =
    add number |> should equal expected

[<Theory>]
[<InlineData("1\n2", 3)>]
[<InlineData("1\n3", 4)>]
[<InlineData("1\n2\n3", 6)>]
[<InlineData("1\n2\n3,4", 10)>]
let AddShouldReturnAdditionOfMultipleNumbersWithDifferentDelimiters number expected = 
    add number |> should equal expected

[<Theory>]
[<InlineData("//;\n1;2", 3)>]
[<InlineData("//;\n1;3", 4)>]
[<InlineData("//-\n1-2-3", 6)>]
[<InlineData("//-\n1-2-3-4", 10)>]
let AddShouldReturnAdditionOfNumbersWithCustomDelimiters numbers expected =
    add numbers |> should equal expected