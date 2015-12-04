open Suave
open Suave.Http.Successful
open Suave.Web
open Suave.Http
open Suave.Http.Applicatives
open System

[<EntryPoint>]
let main [| iisPort |] =
    let iisPort = uint16 iisPort
    printfn "Received port of %d" iisPort
    let config =
        { defaultConfig with
            bindings =
                [ { defaultConfig.bindings.Head with
                        socketBinding = { defaultConfig.bindings.Head.socketBinding with port = iisPort } } ]
        }

    startWebServer config (OK (sprintf "Hello World from Azure Websites, running in a full VS project! No scripts here. Running on port %d" iisPort))
    0 // return an integer exit code