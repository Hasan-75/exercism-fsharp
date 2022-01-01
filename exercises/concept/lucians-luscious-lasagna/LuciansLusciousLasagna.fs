module LuciansLusciousLasagna

let expectedMinutesInOven : int = 40


let remainingMinutesInOven (timeSpent: int) : int =
    match (timeSpent > expectedMinutesInOven) with
    | true ->
        failwith("Spent time cannot be greater than Expected time")
    | false ->
        expectedMinutesInOven - timeSpent


let preparationTimeInMinutes (layers: int) : int =
    layers * 2


let elapsedTimeInMinutes (layers: int) (spentInOven: int) : int =
    layers
    |> preparationTimeInMinutes
    |> (+) spentInOven
