// module definition
module Fizz

// Define fizz function with one parameter:
// tuple of number, boolean, and string
let fizz (ns:int * bool * string) =
  // decompose tuple into 3 values, but
  // we're interested only in the first
  // component - number
  let (n, _, _) = ns
  // divisible by 3?
  if n % 3 = 0 
    // construct new output tuple
    then (n, true, "Fizz")
    else (n, false, sprintf "%d" n)
