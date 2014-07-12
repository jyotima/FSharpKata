// Learn more about f# at http://fsharp.net

namespace FSharpKataTests

exception Thing of string

type Class1() = 
    let Abc = 
        if (4 + 5) > 5 |> not then
            1
        else
            3

type ExampleInterface =
   abstract member print : unit -> unit

type Class2() = 
    let main argv = 
        let x = List.fold (fun x y -> x + y) 0 [1;2;3]
        printfn "%d" x
        0