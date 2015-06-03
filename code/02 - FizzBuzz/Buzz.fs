module Buzz

// Const. F# way
[<Literal>]
let buzzstr = "Buzz"

// Define buzz function with one parameter
// we're not specifying its type here, but
// F# compiler will infere it from the context
let buzz ns =
  // match tuple
  match ns with
  // if the second component is true, and 
  // the first is divisible by 5 - FizzBuzz case
  | (n, true, s) when n % 5 = 0 ->
    // construct new tuple as a result
    (n, true, s + buzzstr)
  // in any other case, i.e. the tuple was not
  // processed earlier, check  Buzz case
  | (n, _, _) -> 
    if n % 5 = 0 
      then (n, true, buzzstr) 
      else ns
