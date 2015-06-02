module Buzz

[<Literal>]
let buzzstr = "Buzz"

let buzz ns =
  match ns with
  | (n, true, s) when n % 5 = 0 ->
    (n, true, s + buzzstr)
  | (n, _, _) -> 
    if n % 5 = 0 
      then (n, true, buzzstr) 
      else ns
