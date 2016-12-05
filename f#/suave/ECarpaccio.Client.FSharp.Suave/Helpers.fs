namespace Helpers

module JsonHelper =
    open Newtonsoft.Json

    let deserialize<'a> (s:string) : 'a option = 
        try
            Some (JsonConvert.DeserializeObject<'a> s)
        with
            _ -> printfn "ERROR can't deserialize : %s" s
                 None

module HttpHelper = 
    open System.Text
    open Suave

    let decodeUTF8ContentToString (request:HttpRequest) =
        Encoding.UTF8.GetString request.rawForm