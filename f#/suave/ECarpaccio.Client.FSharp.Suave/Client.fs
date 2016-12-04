module CarpaccioClient
open System.Net
open Suave
open Suave.Filters
open Suave.Operators
open Suave.Successful
open System.Text

open Handlers

let app =
    choose [
        GET >=>  choose
            [ path "/quote" >=> OK "Hello World!"
              path "/ping" >=> OK "pong" ]
        POST >=> choose
            [ path "/quote" >=> request handleQuote
              path "/feedback" >=> request handleFeedback ]
           ]

let port = Sockets.Port.Parse <| "8080"
let ip = IPAddress.Any

let serverConfig =
    { defaultConfig with
       bindings = [ HttpBinding.mk HTTP ip port ]
    }

[<EntryPoint>]
let main argv =
    printfn "Starting server ..."
    startWebServer serverConfig app
    0
