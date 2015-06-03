// module definition
module Fizz

// Define the fizz function with one parameter:
// tuple of number, boolean, and string
let fizz (ns:int * bool * string) =
  // decompose the tuple into 3 values,
  // but only the first component - number -
  // will be used
  let (n, _, _) = ns
  // divisible by 3?
  if n % 3 = 0 
    // construct new output tuple
    then (n, true, "Fizz")
    else (n, false, sprintf "%d" n)
