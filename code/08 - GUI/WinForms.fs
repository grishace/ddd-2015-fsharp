module WinForms

open System
open System.Drawing
open System.Drawing.Text
open System.Windows.Forms

type HelloWindow(title) as hello = 
  inherit Form(Width = 400, Height = 200, Text = "Hello", StartPosition = FormStartPosition.CenterScreen)
  let msg = "Hello " + title + "!"
  let fnt = new Font("Times New Roman", 28.0f)
  let lbl = new Label(Dock = DockStyle.Fill, Font = fnt,
                        TextAlign = ContentAlignment.MiddleCenter)
  do lbl.Text <- msg
  
  let pnl1 = new Panel(Dock = DockStyle.Bottom, Location = new Point(0, 159), Size = new Size(284, 50))
  let pnl2 = new Panel(Dock = DockStyle.Fill, Location = new Point(0, 0), Size = new Size(284, 150))
  let btn = new Button(Text = "OK", Location = new Point(110, 6), Size = new Size(75, 23), Anchor = AnchorStyles.None)

  do btn.Click.Add(fun _ -> hello.Close())
  
  do pnl1.Controls.Add btn
  do pnl2.Controls.Add lbl
  do hello.Controls.Add pnl1
  do hello.Controls.Add pnl2

[<EntryPoint; STAThread>]
let main _ = 
  use hello = new HelloWindow("Denver Dev Day")
  Application.Run(hello)
  0