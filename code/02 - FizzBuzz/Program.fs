// Import modules
open Fizz
open Buzz

// Compose fizz, buzz, and lambda function
// to extract the third tuple component
let fizzbuzz' = fizz >> buzz >> (fun ns -> 
  let (_, _, s) = ns
  s)

let fizzbuzz =
  // initial sequence of numbers from 1 to 100
  {1 .. 100} 
  // convert to sequence of tuples
  |> Seq.map (fun n -> (n, false, sprintf "%d" n))
  // composed function applied to sequence elements
  |> Seq.map fizzbuzz'

[<EntryPoint>]
let main argv =
  // Create fizzbuzz sequence and print every element
  fizzbuzz |> Seq.iter (printfn "%s")
  0
