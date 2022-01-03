module Leap

let divisibleBy x y =
    y % x = 0

let divisibleBy4 =
    divisibleBy 4

let divisibleBy100 =
    divisibleBy 100

let divisibleBy400 =
    divisibleBy 400

let leapYear (year: int): bool =
    match divisibleBy4 year with
    | true ->
        match divisibleBy100 year with
        | true ->
            match divisibleBy400 year with
            | true -> true
            | false -> false
        | false -> true
    | false -> false