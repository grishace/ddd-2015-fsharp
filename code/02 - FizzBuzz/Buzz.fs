module Buzz

// Const. F# way
[<Literal>]
let buzzstr = "Buzz"

// Define the buzz function with one parameter.
// We're not specifying its type here, but the
// F# compiler will infer it from the context
let buzz ns =
  // match tuple
  match ns with
  // if the second component is true, and 
  // the first is divisible by 5 - FizzBuzz case
  | (n, true, s) when n % 5 = 0 ->
    // construct new tuple as the result
    (n, true, s + buzzstr)
  // in any other case, i.e. the tuple was not
  // processed earlier, check the Buzz case
  | (n, _, _) -> 
    if n % 5 = 0 
      then (n, true, buzzstr) 
      else ns
