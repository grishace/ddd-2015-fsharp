// Folding sequence with *
let fact n = {1 .. n} |> Seq.fold (*) 1

// Reducing sequence (use big ints to extend
// calculation range)
let fact' n:bigint = {1I .. n} |> Seq.reduce (*)

// Naive recursion (exactly the same as math)
let rec f n =
  match n with
  | 0 -> 1
  | _ -> f (n - 1) * n

// Hiding recursion with local tail-recursive call
// passing the accumulator on each recursion
let f' n =
  let rec fr n a =
    match n with
    | 0 -> a
    | _ -> fr (n - 1) (a * n)
  fr n 1

[<EntryPoint>]
let main argv = 
    0
