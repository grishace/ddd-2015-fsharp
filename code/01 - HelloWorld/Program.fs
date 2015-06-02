// using namespace
open System

// entry point attribute for console app
[<EntryPoint>]
// main function
// note: no args type
let main argv =
  printfn "Hello World"
  // ignore function result
  // note: pipe operator - result from the left is passed as the last parameter to the next function
  Console.ReadLine() |> ignore
  // return value, i.e. exit code
  0

// Try:
// printfn "Hello %s" "World"
// printfn "Hello %s" 1
