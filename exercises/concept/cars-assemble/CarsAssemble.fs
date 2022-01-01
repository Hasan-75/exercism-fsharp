module CarsAssemble

let prodPerHour : float = 221

let successRate (speed: int): float =
    match speed with
    | 0 -> 0.0
    | x when x < 5 -> 1.0
    | x when x < 9 -> 0.9
    | 9 -> 0.8
    | 10 -> 0.77
    | _ -> failwith("Speed must be in range 0 - 10")

let productionRatePerHour (speed: int): float =
    speed
    |> successRate
    |> (*) prodPerHour
    |> (*) (float speed)

let workingItemsPerMinute (speed: int): int =
    speed
    |> productionRatePerHour
    |> fun x -> x / 60.0
    |> int