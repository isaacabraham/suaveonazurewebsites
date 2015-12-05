#load "load-references-debug.fsx"

open Microsoft.ApplicationInsights.Extensibility
open Microsoft.ApplicationInsights
open System

TelemetryConfiguration.Active.InstrumentationKey <- "b192c79e-b379-4dfd-b69d-3326bfa85ceb"
let c = TelemetryClient()
c.Context.InstrumentationKey <- "b192c79e-b379-4dfd-b69d-3326bfa85ceb"

c.TrackRequest("Sample", DateTimeOffset.UtcNow, TimeSpan.FromSeconds 5., "200", true)
c.Context