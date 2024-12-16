open System

let data = "Tim,Sue,Bob,Jane"
let firstNames = data.Split(',') |> List.ofArray

for firstName in firstNames do
    printfn "%s" firstName
