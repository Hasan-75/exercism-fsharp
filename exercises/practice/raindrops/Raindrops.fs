module Raindrops

let getWord (x: int) : string =
    match x with
    | 3 -> "Pling"
    | 5 -> "Plang"
    | 7 -> "Plong"
    | _ -> ""

let getSound (y: int) (x: int): string =
    match y % x = 0 with
    | true -> getWord x
    | false -> ""

let convert (number: int): string =
    let sound =
        [3; 5; 7]
        |> List.map (getSound number)
        |> List.fold
            (fun result slice-> result + slice) ""

    match sound with
    | "" -> number |> string
    | _ -> sound