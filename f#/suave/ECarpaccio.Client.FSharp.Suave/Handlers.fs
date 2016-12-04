module Handlers

open System.Net
open Suave
open Suave.Filters
open Suave.Operators
open Suave.Successful
open Suave.RequestErrors
open System.Text

open CarpaccioModel
open Helpers
open HttpHelper
open JsonHelper

let decodeAndDeserialize<'a> = decodeUTF8ContentToString >> deserialize<'a>

let handleFeedback (r:HttpRequest) =
    decodeAndDeserialize<Feedback> r
    |> printfn "Feedback -> %A" ; 
    no_content

let handleQuote (r:HttpRequest) =
    decodeAndDeserialize<Quote> r
    |> printfn "quote received -> %A"
    OK ""