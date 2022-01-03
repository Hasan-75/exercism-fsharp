module GuessingGame

let selected = 42

let reply (guess: int): string =
    match guess - selected with
    | 0 -> "Correct"
    | -1
    | 1 -> "So close"
    | x when x < -1 -> "Too low"
    | _ -> "Too high"
