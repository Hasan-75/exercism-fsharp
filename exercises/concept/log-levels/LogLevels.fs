module LogLevels

type LogLevel =
    | INFO of string
    | WARNING of string
    | ERROR of string

let clean (s: string) : string =
    s.Trim()

let parseLog (logLine: string) : LogLevel =
    let words =
        logLine
        |> fun s -> s.Split([|' '|])
        |> List.ofArray
        |> List.map clean

    let wordsToStr (wSeq: seq<string>) =
        String.concat " " wSeq
        |> clean

    match words with
    | "[INFO]:" :: rest ->
        rest
        |> wordsToStr
        |> INFO
    | "[ERROR]:" :: rest ->
        rest
        |> wordsToStr
        |> ERROR
    | "[WARNING]:" :: rest ->
        rest
        |> wordsToStr
        |> WARNING
    | _ -> failwith "Invalid level"

let message (logLine: string): string =
    let log = parseLog logLine

    match log with
    | INFO msg
    | WARNING msg
    | ERROR msg
        -> msg


let logLevel(logLine: string): string =
    let log = parseLog logLine

    match log with
    | INFO _ -> "info"
    | ERROR _ -> "error"
    | WARNING _ -> "warning"


let reformat(logLine: string): string =
    let level =
        logLine
        |> logLevel

    let msg =
        logLine
        |> message

    sprintf "%s (%s)" msg level