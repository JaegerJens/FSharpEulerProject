namespace EulerProject

module Main =
    open System
        [<EntryPoint>]
        let main argv = 
            Problem1.result |> printfn "Problem 1 result: %A"
            Problem2.result |> printfn "Problem 2 result: %A"
            Console.ReadKey() |> ignore
            0 // return an integer exit code
