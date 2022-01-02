module InterestIsInteresting

let percentToDecimal (percent: single) : decimal =
    percent
    |> decimal
    |> (*) 0.01m

let interestRate (balance: decimal): single =
    match balance with
    | x when x < 0m -> 3.213f
    | x when x < 1000m -> 0.5f
    | x when x >= 1000m && x < 5000m -> 1.621f
    | _ -> 2.475f

let interest (balance: decimal): decimal =
   balance
   |> interestRate
   |> percentToDecimal
   |> (*) balance

let annualBalanceUpdate(balance: decimal): decimal =
   balance
   |> interest
   |> (+) balance

let amountToDonate(balance: decimal) (taxFreePercentage: float): int =
    match balance < 0m with
    | true -> 0
    | false ->
       taxFreePercentage
       |> single
       |> percentToDecimal
       |> (*) balance
       |> (*) 2m
       |> int