// Degrees of Farenheit
[<Measure>]
type F

// Degrees of Celsius
[<Measure>]
type C =
  // Convert Celsius into Farenheit
  static member asF t = t * 9.0<F>/5.0<C> + 32.0<F>

// Check if AC should be turned on
let isACOn (t:float<F>) = t > 72.0<F>

[<EntryPoint>]
let main argv = 
  // printfn "%b" (isACOn 25.0)
  // printfn "%b" (isACOn 25.0<C>)
  printfn "%b" (isACOn (C.asF 25.0<C>))
  printfn "%b" (isACOn 32.0<F>)
  0
