open Suave.Http.Successful
open Suave.Web
open Suave.Http
open Suave.Types
open System
open System.Net

//If running locally, make sure you you supply a port number to the executable.
[<EntryPoint>]
let main [| port |] =
    let config = { defaultConfig with bindings = [ HttpBinding.mk HTTP IPAddress.Loopback (uint16 port) ] }
    startWebServer config (warbler (fun _ -> OK (sprintf "%O: Hello World from Suave running on Azure Websites in a full VS project! No scripts here. Running on port %s." DateTime.UtcNow port)))
    0