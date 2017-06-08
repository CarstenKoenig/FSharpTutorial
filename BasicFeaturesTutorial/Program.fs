// Learn more about F# at http://fsharp.org
// See the 'F# Tutorial' project for more help.
open TypeProvider
open BulletPointFormatter 

[<EntryPoint>]
let main argv = 

    for item in People.GetSamples() do 
      printf "%s " item.Name 
      item.Age |> Option.iter (printf "(%d)")
      printfn ""

    for bd in BankData.Array do 
        printfn "%s" bd.Country.Value
        printfn "%d" bd.Date

    let nList = 
        [   { Line = { Weight = HW1; Text = "All About Birds" } } 
            { Line ={ Weight = HW2; Text = "Kinds of Birds" } } 
            { Line ={ Weight = HW3; Text = "The Finch" } } 
            { Line ={ Weight = HW3; Text = "The Swan" } }
            { Line ={ Weight = HW2; Text = "The habitats" } }
            { Line ={ Weight = HW3; Text = "Wetland" } }
            { Line ={ Weight = HW3; Text = "Sky" } } ]
    let outline = formatTextOutline nList
    printf "%s" outline.Text

    printfn "%A" argv
    0 // return an integer exit code
