module StringCalculatorTests

// AddShouldReturn0OnEmptyNumber
// AddShouldReturnNumberIfSingleNumberIsPassed
// AddShouldReturnAdditionOfNumbersIfTwoNumbersArePassed
// AddShouldReturnAdditionOfNumbersIfNewLineDelimiterIsPassed
// AddShouldReturnAdditionOfNumbersIfMultipleNumbersArePassed
// AddShouldReturnAdditionOfNumbersIfCustomDelimitersArePassed
// AddShouldThrowIfNegativeNumbersArePassed

open StringCalculator
open Xunit
open FsUnit.Xunit
open Xunit.Extensions

[<Fact>]
let AddShouldReturn0OnEmptyNumber() =
    add "" |> should equal (Some(0))

[<Theory>]
[<InlineData("0", 0)>]
[<InlineData("1", 1)>]
[<InlineData("2", 2)>]
let AddShouldReturnNumberIfSingleNumberIsPassed number expected =
    add number |> should equal (Some(expected))

[<Theory>]
[<InlineData("1,2", 3)>]
[<InlineData("1,3", 4)>]
[<InlineData("1,2,3", 6)>]
[<InlineData("1,2,3,4", 10)>]
let AddShouldReturnAdditionOfNumbersIfManyNumbersArePassed numbers expected =
    add numbers |> should equal (Some(expected))
    
[<Theory>]
[<InlineData("1\n2", 3)>]
[<InlineData("1\n3", 4)>]
[<InlineData("1\n2\n3", 6)>]
[<InlineData("1\n2\n3,4", 10)>]
let AddShouldReturnAdditionOfNumbersIfNewLineDelimiterIsPassed numbers expected =
    add numbers |> should equal (Some(expected))

[<Theory>]
[<InlineData("//;\n1;2", 3)>]
[<InlineData("//;\n1;3", 4)>]
[<InlineData("//-\n1-2-3", 6)>]
[<InlineData("//-\n1-2-3-4", 10)>]
let AddShouldReturnAdditionOfNumbersIfCustomDelimitersArePassed numbers expected =
    add numbers |> should equal (Some(expected))

[<Fact>]
let AddShouldReturnNoneIfNegativeNumbersArePassed() =
    add "1,-2" |> should equal None