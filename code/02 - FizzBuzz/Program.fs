open System

let fizz n =
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

let fizzbuzz =
  {1 .. 100} 
  |> Seq.map fizz 
  |> Seq.map buzz 
  |> Seq.map snd

[<EntryPoint>]
let main argv = 
  fizzbuzz |> Seq.iter (printfn "%s")
  0
