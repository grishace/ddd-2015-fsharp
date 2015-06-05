// Create some task
let cpuTask() =
  for i in [1 .. 1000] do
    for i in [1 .. 1000] do
      do "Hello".Contains("H") |> ignore

// And compose it 20 times
let heavyTask =
  cpuTask
  |> List.replicate 20
  |> List.reduce (>>)

// Let's try async to compare
// note: don't forget #time

// Wrap task in async block
let asyncCpuTask = async { return cpuTask() }

// Create 20 parallel async tasks
let asyncHeavyTask = 
  asyncCpuTask
  |> List.replicate 20
  |> Async.Parallel

// Run them
let run =
  asyncHeavyTask
  |> Async.RunSynchronously
  |> ignore
