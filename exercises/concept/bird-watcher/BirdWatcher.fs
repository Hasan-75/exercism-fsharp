module BirdWatcher

let lastWeek: int[] =
   [| 0; 2; 5; 3; 7; 8; 4 |]

let yesterday(counts: int[]): int =
  counts.Length - 2
  |> Array.get counts

let total(counts: int[]): int =
  counts
  |> Array.sum

let dayWithoutBirds(counts: int[]): bool =
  counts
  |> Array.contains 0

let incrementTodaysCount(counts: int[]): int[] =
    let lastIndex =counts.Length - 1
    do counts.[lastIndex] <- counts.[lastIndex] + 1
    counts

let oddWeek(counts: int[]): bool =
    match counts with
    | [| _; 0; _; 0; _; 0; _ |] -> true
    | [| _; 10; _; 10; _; 10; _ |] -> true
    | [| 5; _; 5; _; 5; _; 5 |] -> true
    | _ -> false