let fact n = {1 .. n} |> Seq.fold (*) 1

let fact' n:bigint = {1I .. n} |> Seq.reduce (*)

let rec f n =
  match n with
  | 0 -> 1
  | _ -> f (n - 1) * n

let f' n =
  let rec fr n a =
    match n with
    | 0 -> a
    | _ -> fr (n - 1) (a * n)
  fr n 1

[<EntryPoint>]
let main argv = 
    0
