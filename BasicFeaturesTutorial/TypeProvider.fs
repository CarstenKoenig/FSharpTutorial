module TypeProvider
open FSharp.Data

type People = JsonProvider<""" 
  [ { "name":"John", "age":94 }, 
    { "name":"Tomas" } ] """>

for item in People.GetSamples() do 
  printf "%s " item.Name 
  item.Age |> Option.iter (printf "(%d)")
  printfn ""


type WorldBank = JsonProvider<"""[ { "page": 1, "pages": 1, "total": 53 },
  [ { "indicator": {"value": "Central government debt, total (% of GDP)"},
      "country": {"id":"CZ","value":"Czech Republic"},
      "value":null,"decimal":"1","date":"2000"},
    { "indicator": {"value": "Central government debt, total (% of GDP)"},
      "country": {"id":"CAN","value":"Canada"},
      "value":"16.6567773464055","decimal":"1","date":"2010"} ] ]""">
let BankData = WorldBank.GetSample()