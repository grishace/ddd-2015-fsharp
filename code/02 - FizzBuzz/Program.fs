open Fizz
open Buzz

let fizzbuzz' = fizz >> buzz >> (fun ns -> 
  let (_, _, s) = ns
  s)

let fizzbuzz =
  {1 .. 100} 
  |> Seq.map (fun x -> (x, false, sprintf "%d" x))
  |> Seq.map fizzbuzz'

[<EntryPoint>]
let main argv = 
  fizzbuzz |> Seq.iter (printfn "%s")
  0
