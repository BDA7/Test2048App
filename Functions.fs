module Functions

open System

let rec shifLeftUp (arr: string[]) (value: string) (i: int) =
    if (i < 0) || (arr.[i] <> "") then
        (arr)
    else
        arr.[i + 1] <- ""
        arr.[i] <- value
        shifLeftUp arr value (i - 1)


let rec shiftRightDown (arr: string[]) (value: string) (i: int) (size: int) =
    if (i > size - 1) || (arr.[i] <> "") then
        (arr)
    else
        arr.[i] <- value
        arr.[i - 1] <- ""
        shiftRightDown arr value (i + 1) size



let shiftLeft (elemsArr: string[,]) (sizeLine: int) =
    for i in 0 .. (sizeLine - 1) do
        for j in 0 .. (sizeLine - 1) do
            if elemsArr.[i, j] <> "" then
                elemsArr.[i, *] <- shifLeftUp elemsArr.[i, *] elemsArr.[i, j] (j - 1)

    (elemsArr)


let shiftRight (elemsArr: string[,]) (sizeLine: int) =
    for i in 0 .. (sizeLine - 1) do
        for j in (sizeLine - 1) .. -1 .. 0 do
            if (elemsArr.[i, j] <> "") then
                elemsArr.[i, *] <- shiftRightDown elemsArr.[i, *] elemsArr.[i, j] (j + 1) sizeLine

    (elemsArr)


let shiftUp (elemsArr: string[,]) (sizeLine: int) =
    for i in 0 .. (sizeLine - 1) do
        for j in 0 .. (sizeLine - 1) do
            if (elemsArr.[j, i] <> "") then
                elemsArr.[*, i] <- shifLeftUp elemsArr.[*, i] elemsArr.[j, i] (j - 1)

    (elemsArr)


let shiftDown (elemsArr: string[,]) (sizeLine: int) =
    for i in 0 .. (sizeLine - 1) do
        for j in (sizeLine - 1) .. -1 .. 0 do
            if (elemsArr.[j, i] <> "") then
                elemsArr.[*, i] <- shiftRightDown elemsArr.[*, i] elemsArr.[j, i] (j + 1) sizeLine

    (elemsArr)



let sumLeft (elemsArr: string[,]) (sizeLine: int) =
    for i in 0 .. (sizeLine - 1) do
        for j in 0 .. (sizeLine - 2) do
            if (elemsArr.[i, j] = elemsArr.[i, j + 1]) && (elemsArr.[i, j] <> "") then
                let value = elemsArr.[i, j] |> int
                elemsArr.[i, j] <- (value * 2).ToString()
                elemsArr.[i, j + 1] <- ""

    (elemsArr)


let sumRight (elemsArr: string[,]) (sizeLine: int) =
    for i in 0 .. (sizeLine - 1) do
        for j in (sizeLine - 1) .. -1 .. 1 do
            if (elemsArr.[i, j] = elemsArr.[i, j - 1]) && (elemsArr.[i, j] <> "") then
                let value = elemsArr.[i, j] |> int
                elemsArr.[i, j] <- (value * 2).ToString()
                elemsArr.[i, j - 1] <- ""

    (elemsArr)


let sumUp (elemsArr: string[,]) (sizeLine: int) =
    for i in 0 .. (sizeLine - 1) do
        for j in 0 .. (sizeLine - 2) do
            if (elemsArr.[j, i] = elemsArr.[j + 1, i]) && (elemsArr.[j, i] <> "") then
                let value = elemsArr.[j, i] |> int
                elemsArr.[j, i] <- (value * 2).ToString()
                elemsArr.[j + 1, i] <- ""

    (elemsArr)


let sumDown (elemsArr: string[,]) (sizeLine: int) =
    for i in 0 .. (sizeLine - 1) do
        for j in (sizeLine - 1) .. -1 .. 1 do
            if (elemsArr.[j, i] = elemsArr.[j - 1, i]) && (elemsArr.[j, i] <> "") then
                let value = elemsArr.[j, i] |> int
                elemsArr.[j, i] <- (value * 2).ToString()
                elemsArr.[j - 1, i] <- ""

    (elemsArr)
