// Degrees of Farenheit
[<Measure>]
type F

// Degrees of Celsius
[<Measure>]
type C

// Check if AC should be turned on
let isACOn (t:float<F>) = t > 72.0<F>

[<EntryPoint>]
let main argv = 
  // Convert Celsius into Farenheit
  let C2F (t:float<C>) = t * 9.0<F>/5.0<C> + 32.0<F>
  // printfn "%b" (isACOn 25.0)
  // printfn "%b" (isACOn 25.0<C>)
  printfn "%b" (isACOn (C2F 25.0<C>))
  printfn "%b" (isACOn 32.0<F>)
  0
