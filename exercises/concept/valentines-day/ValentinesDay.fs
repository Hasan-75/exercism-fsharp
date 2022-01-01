module ValentinesDay

type Approval =
    | Yes
    | No
    | Maybe

type Cuisine =
    | Korean
    | Turkish

type Genre =
    | Crime
    | Horror
    | Romance
    | Thriller

type Activity =
    | BoardGame
    | Chill
    | Movie of Genre
    | Restaurant of Cuisine
    | Walk of int

let rateActivity (activity: Activity): Approval =
    match activity with
    | BoardGame
    | Chill -> No
    | Movie genre ->
        match genre with
        | Romance -> Yes
        | _ -> No
    | Restaurant cusine ->
        match cusine with
        | Korean -> Yes
        | Turkish -> Maybe
    | Walk distance ->
        match distance with
        | x when x < 3 -> Yes
        | x when x < 5 -> Maybe
        | _ -> No