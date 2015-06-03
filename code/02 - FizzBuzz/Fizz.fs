module Fizz

let fizz (ns:int * bool * string) =
  let (n, _, _) = ns
  if n % 3 = 0 
    then (n, true, "Fizz")
    else (n, false, sprintf "%d" n)
