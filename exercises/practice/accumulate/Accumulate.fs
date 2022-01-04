module Accumulate

let accumulate (func: 'a -> 'b) (input: 'a list) : 'b list =
    let rec tailRecursion (result: 'b list) (tail: 'a list) : 'b list =
        match tail with
        | [] -> result
        | head :: rest ->
            tailRecursion (func head :: result) rest
    
    tailRecursion [] input
    |> List.rev