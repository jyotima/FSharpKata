﻿module FSharpLibTests1

open FsUnit
open Xunit
open FsUnit.Xunit

[<Fact>]
let ``first test case``() = 
    1 |> should equal 1
    1 |> should not' (equal 2)
    10.1 |> should (equalWithin 0.1) 10.11
    10.1 |> should not' ((equalWithin 0.001) 10.11)
    "ships" |> should startWith "sh"
    "ships" |> should not' (startWith "ss")
    "ships" |> should endWith "ps"
    "ships" |> should not' (endWith "ss")
    [ 1 ] |> should contain 1
    [] |> should not' (contain 1)
    true |> should be True
    false |> should not' (be True)
    "" |> should be EmptyString
    "" |> should be NullOrEmptyString
    null |> should be NullOrEmptyString
    null |> should be Null
    // TODO: Enable this: anObj |> should not' (be Null) bunch of object related ones at https://github.com/fsharp/fsunit
    11 |> should be (greaterThan 10)
    1 |> should not' (be ofExactType<obj>)
    // TODO: Enable this: (fun () -> failwith "BOOM!") |> should throw typeof<System.Exception>

    // NUnit specific only , but currently not working even on referencing fsunit nunit
    // [] |> should be Empty // NUnit only
    // [1] |> should not' (be Empty) // NUnit only
    // "test" |> should be instanceOfType<string> // Currently, NUnit only and requires version 1.0.1.0+
    // "test" |> should not' (be instanceOfType<int>) // Currently, NUnit only and requires version 1.0.1.0+
    // 2.0 |> should not' (be NaN) // Currently, NUnit only and requires version 1.0.1.0+
    // [1;2;3] |> should be unique // Currently, NUnit only and requires version 1.0.1.0+