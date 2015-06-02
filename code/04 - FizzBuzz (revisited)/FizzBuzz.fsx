let fizzbuzz = 
  let fb n = match n with
             | i when i % 3 = 0 && i % 5 = 0 -> "FizzBuzz"
             | i when i % 3 = 0 -> "Fizz"
             | i when i % 5 = 0 -> "Buzz"
             | _ -> sprintf "%d" n
  Seq.unfold (fun n -> Some((fb n), n + 1)) 1

let fizzbuzz' = 
  let rec fb n = seq {
    match n with
    | i when i % 3 = 0 && i % 5 = 0 -> yield "FizzBuzz"
    | i when i % 3 = 0 -> yield "Fizz"
    | i when i % 5 = 0 -> yield "Buzz"
    | _ -> yield sprintf "%d" n
    yield! fb (n + 1)
  }
  fb 1
   
Seq.take 100 fizzbuzz' |> Seq.iter( printfn "%s" )
