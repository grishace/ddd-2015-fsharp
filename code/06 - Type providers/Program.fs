#if INTERACTIVE
#r "../packages/FSharp.Data.2.4.6/lib/net45/FSharp.Data.dll"
#load "../packages/FSharp.Charting.0.91.1/lib/net45/FSharp.Charting.fsx"
#endif

open System
open FSharp.Data
open FSharp.Charting

type Stocks = CsvProvider<"YAHOO-INDEX_GSPC.csv">
let sp500 = Stocks.Load("YAHOO-INDEX_GSPC.csv")

// Visualize the stock prices
[ for row in sp500.Rows -> row.Date, row.Open ]
|> Chart.FastLine
// note: don't run in fsi
|> ignore

let cutOff = DateTime(2015, 06, 02)

// Get some prices in HLOC format 
let recent = 
  [ for row in sp500.Rows do
      if row.Date > cutOff.AddDays(-30.0) then
        yield row.Date, row.High, row.Low, row.Open, row.Close ]
  |> List.sortBy(fun x -> match x with (d, _, _, _, _) -> d)

// Visualize prices using Candlestick chart
Chart.Candlestick(recent).WithYAxis(Min = 2000.0, Max = 2200.0)
// note: don't run in fsi
|> ignore


// Let's load the same data from SQLite database

#if INTERACTIVE
#r "../packages/SQLProvider.1.1.41/lib/net451/FSharp.Data.SqlProvider.dll " 
#endif

open FSharp.Data.Sql
open System
open System.Linq

type sql = SqlDataProvider< 
              ConnectionString = @"Data Source=C:\Github\ddd-2018-fsharp\code\06 - Type providers\YAHOO-INDEX_GSPC.db;Version=3",
              DatabaseVendor = Common.DatabaseProviderTypes.SQLITE,
              ResolutionPath = @"C:\temp\sqlite3",
              IndividualsAmount = 1000,
              UseOptionTypes = false >

let ctx = sql.GetDataContext()

// note: show intellisense
let mattisOrderDetails = 
    query { for c in ctx.Main.Sp500 do
            select ( c.Date, c.Open ) }
    |> Chart.FastLine

let candlestick = 
  query { for c in ctx.Main.Sp500 do
          where (c.Date > cutOff.AddDays(-30.0))
          sortBy c.Date
          select ( c.Date, c.High, c.Low, c.Open, c.Close ) }

Chart.Candlestick(candlestick).WithYAxis(Min = 2000.0, Max = 2200.0)
// note: don't run in fsi
|> ignore

[<EntryPoint>]
let main argv = 
    0
