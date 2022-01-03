module TisburyTreasureHunt

let charToNumeric (ch: char) : int =
    int ch - int '0'

let getCoordinate (line: string * string): string =
    snd line

let convertCoordinate (coordinate: string): int * char = 
    let chars = coordinate.ToCharArray()
    (charToNumeric chars.[0], chars.[1])

let compareRecords (azarasData: string * string) (ruisData: string * (int * char) * string) : bool = 
    let (_, rCoord, _) = ruisData
    let aCoord = 
        azarasData 
        |> getCoordinate
        |> convertCoordinate
    aCoord = rCoord

let createRecord (azarasData: string * string) (ruisData: string * (int * char) * string) : (string * string * string * string) =
    let (treasureName, coordinate) = azarasData
    let (location, _, quadrant) = ruisData

    let isSame = compareRecords azarasData ruisData

    match isSame with
    | true ->
        ( coordinate, location, quadrant, treasureName )
    | false ->
        ( "", "", "", "" )