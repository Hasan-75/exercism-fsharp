module QueenAttack

let create (position: int * int) : bool =
    (fst position >= 0 && fst position < 8)
    &&
    (snd position >= 0 && snd position < 8)

let canAttack (queen1: int * int) (queen2: int * int) =
    let x1, y1 = queen1
    let x2, y2 = queen2

    x1 = x2
    ||
    y1 = y2
    ||
    abs (x1 - x2) = abs (y1 - y2)