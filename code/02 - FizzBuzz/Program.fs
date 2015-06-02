open System

let fizz (ns:int * string) =
  let n = fst ns
  if n % 3 = 0 
    then (n, "Fizz")
    else (n, sprintf "%d" n)

let buzz ns =
  match ns with
  | (n, "Fizz") when n % 5 = 0 ->
    (n, "FizzBuzz")
  | (n, b) -> 
    if n % 5 = 0 
      then (n, "Buzz") 
      else ns

let fizzbuzz' = fizz >> buzz >> snd

let fizzbuzz =
  {1 .. 100} 
  |> Seq.map (fun x -> (x, sprintf "%d" x))
  |> Seq.map fizzbuzz'

[<EntryPoint>]
let main argv = 
  fizzbuzz |> Seq.iter (printfn "%s")
  0
