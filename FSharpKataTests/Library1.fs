// Learn more about f# at http://fsharp.net

namespace FSharpKataTests

exception ThingException of string

type Class1() = 
    let someFunction = 
        if (4 + 5) <= 5 then
            1
        else
            3

type IExampleInterface =
   abstract member Print : unit -> unit

type Class2() = 
    let main argv = 
        let x = List.sum [1;2;3]
        printfn "%d" x
        0