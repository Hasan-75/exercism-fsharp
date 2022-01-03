module PizzaPricing

type Pizza =
    | Margherita
    | Caprese
    | Formaggio
    | ExtraSauce of Pizza
    | ExtraToppings of Pizza

let rec pizzaPrice (pizza: Pizza): int =
    match pizza with
    | Margherita -> 7
    | Caprese -> 9
    | Formaggio -> 10
    | ExtraSauce p -> 1 + (pizzaPrice p)
    | ExtraToppings p -> 2 + (pizzaPrice p)

let calculateAdditionalFee (pizzas: Pizza list) : int =
    match pizzas.Length with
    | 1 -> 3
    | 2 -> 2
    | _ -> 0

let orderPrice(pizzas: Pizza list): int =
    pizzas
    |> List.map pizzaPrice
    |> List.sum
    |> (+) (calculateAdditionalFee pizzas)