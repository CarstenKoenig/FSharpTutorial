// Learn more about F# at http://fsharp.org
// See the 'F# Tutorial' project for more help.
open TypeProvider

[<EntryPoint>]
let main argv = 

    for item in People.GetSamples() do 
      printf "%s " item.Name 
      item.Age |> Option.iter (printf "(%d)")
      printfn ""

    for bd in BankData.Array do 
        printfn "%s" bd.Country.Value
        printfn "%d" bd.Date

    printfn "%A" argv
    0 // return an integer exit code
