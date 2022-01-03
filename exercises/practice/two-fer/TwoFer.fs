module TwoFer


let twoFer (input: string option): string =
    let statement =
        sprintf "One for %s, one for me."

    match input with
    | Some name -> statement name
    | None -> statement "you"