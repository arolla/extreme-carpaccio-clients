module CarpaccioModel
open System

[<CLIMutable>]
type Bill = { quote: decimal }
  
[<CLIMutable>]
type Feedback = { message: string }

[<CLIMutable>]
type Quote = { country: string }