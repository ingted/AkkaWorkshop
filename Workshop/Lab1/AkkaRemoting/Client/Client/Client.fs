module Client

open Akka.FSharp
open Akka.Actor
open Akka.Remote
open Akka.Configuration
open System
open System.Threading.Tasks

[<EntryPoint>]
let main argv = 
    let config = """
        akka {  
            log-config-on-start = on        
            stdout-loglevel = DEBUG
            loglevel = DEBUG
          
            actor {
                provider = "Akka.Remote.RemoteActorRefProvider, Akka.Remote"
            }    
            remote.helios.tcp {
                transport-protocol = tcp
                port = 8091                 
                hostname = 10.211.55.2
                }
        }
        """
    System.Console.Title <- "Client : " + System.Diagnostics.Process.GetCurrentProcess().Id.ToString()

    use remoteSystem = System.create "remote-system" (Configuration.parse config)

    Console.ForegroundColor <- ConsoleColor.Green
    printfn "Remote Actor %s listening..." remoteSystem.Name


    System.Console.ReadLine() |> ignore

    remoteSystem.Terminate().Wait()

    Console.ReadLine() |> ignore
    0



