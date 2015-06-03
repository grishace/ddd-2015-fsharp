let fizzbuzz = 
  // local function returning FizzBuzz for input n
  let fb n = match n with
             | i when i % 3 = 0 && i % 5 = 0 -> "FizzBuzz"
             | i when i % 3 = 0 -> "Fizz"
             | i when i % 5 = 0 -> "Buzz"
             | _ -> sprintf "%d" n
  // Sequence generation with unfold:
  // lambda function to create option 
  // tuple of current sequence element (fb n)
  // and the next state (n + 1)
  // the last parameter is the initial state (1)
  Seq.unfold (fun n -> Some((fb n), n + 1)) 1

let fizzbuzz' = 
  // local recursive sequence generator
  let rec fb n = seq {
    // yield FizzBuzz into the output sequence
    match n with
    | i when i % 15 = 0 -> yield "FizzBuzz"
    | i when i % 3 = 0 -> yield "Fizz"
    | i when i % 5 = 0 -> yield "Buzz"
    | _ -> yield sprintf "%d" n
    // recursive sequence starting with the
    // next (+1) number
    yield! fb (n + 1)
  }
  // start generation from 1
  fb 1

// take first 100 elements of the sequence 
// and print them
Seq.take 100 fizzbuzz' |> Seq.iter( printfn "%s" )
