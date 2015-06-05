module WPF

open System
open System.Windows
open System.Windows.Controls
open System.Windows.Media

type HelloWorldWindow() as this =
  inherit Window()

  let mainPanel = 
    let grid = Grid()
    [ RowDefinition(); RowDefinition() ] |> List.iter grid.RowDefinitions.Add
    grid.ColumnDefinitions.Add (ColumnDefinition())
    grid

  let ok = Button(Content = "OK", Width = 50., Height = 25.)
  let msg = Label(HorizontalAlignment = HorizontalAlignment.Center, VerticalContentAlignment = VerticalAlignment.Center, FontFamily = FontFamily("Times New Roman"), FontSize = 28.)

  do 
    this.Width <- 400.
    this.Height <- 200.
    this.WindowStartupLocation <- WindowStartupLocation.CenterScreen
    this.Title <- "Hello"

    msg.SetValue(Grid.RowProperty, 0)
    msg.SetValue(Grid.ColumnProperty, 0)
    msg.Content <- "Hello Denver Dev Day"
    mainPanel.Children.Add msg |> ignore

    ok.SetValue(Grid.RowProperty, 1)
    ok.SetValue(Grid.ColumnProperty, 0)
    ok.Click.Add (fun _-> Application.Current.Shutdown() )
    mainPanel.Children.Add ok |> ignore

    this.Content <- mainPanel

[<STAThread>]
let main _ = 
  let hello = new HelloWorldWindow()
  let app = new Application()
  app.Run(window = hello)