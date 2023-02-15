module Tests

open System
open Xunit
open Functions

let createArr () =
    let arr2D = Array2D.create 5 5 ""
    arr2D.[0, *] <- [| ""; "4"; ""; "8"; "4" |]
    arr2D.[1, *] <- [| "4"; ""; ""; "8"; "4" |]
    arr2D.[3, *] <- [| ""; ""; "8"; "8"; "" |]
    arr2D.[4, *] <- [| "2"; "4"; "8"; "8"; "4" |]
    (arr2D)

[<Fact>]
let ``shiftLeft Test`` () =
    let arr2D = createArr ()

    let arr2DCorrect = Array2D.create 5 5 ""
    arr2DCorrect.[0, *] <- [| "4"; "8"; "4"; ""; "" |]
    arr2DCorrect.[1, *] <- [| "4"; "8"; "4"; ""; "" |]
    arr2DCorrect.[3, *] <- [| "8"; "8"; ""; ""; "" |]
    arr2DCorrect.[4, *] <- [| "2"; "4"; "8"; "8"; "4" |]
    let useFunc = shiftLeft arr2D 5
    Assert.Equal(arr2DCorrect, useFunc)


[<Fact>]
let ``shiftRight Test`` () =
    let arr2D = createArr ()

    let arr2DCorrect = Array2D.create 5 5 ""
    arr2DCorrect.[0, *] <- [| ""; ""; "4"; "8"; "4" |]
    arr2DCorrect.[1, *] <- [| ""; ""; "4"; "8"; "4" |]
    arr2DCorrect.[3, *] <- [| ""; ""; ""; "8"; "8" |]
    arr2DCorrect.[4, *] <- [| "2"; "4"; "8"; "8"; "4" |]
    let useFunc = shiftRight arr2D 5
    Assert.Equal(arr2DCorrect, useFunc)

[<Fact>]
let ``shiftUp Test`` () =
    let arr2D = createArr ()

    let arr2DCorrect = Array2D.create 5 5 ""
    arr2DCorrect.[0, *] <- [| "4"; "4"; "8"; "8"; "4" |]
    arr2DCorrect.[1, *] <- [| "2"; "4"; "8"; "8"; "4" |]
    arr2DCorrect.[2, *] <- [| ""; ""; ""; "8"; "4" |]
    arr2DCorrect.[3, *] <- [| ""; ""; ""; "8"; "" |]
    arr2DCorrect.[4, *] <- [| ""; ""; ""; ""; "" |]
    let useFunc = shiftUp arr2D 5
    Assert.Equal(arr2DCorrect, useFunc)

[<Fact>]
let ``shiftDown Test`` () =
    let arr2D = createArr ()

    let arr2DCorrect = Array2D.create 5 5 ""
    arr2DCorrect.[0, *] <- [| ""; ""; ""; ""; "" |]
    arr2DCorrect.[1, *] <- [| ""; ""; ""; "8"; "" |]
    arr2DCorrect.[2, *] <- [| ""; ""; ""; "8"; "4" |]
    arr2DCorrect.[3, *] <- [| "4"; "4"; "8"; "8"; "4" |]
    arr2DCorrect.[4, *] <- [| "2"; "4"; "8"; "8"; "4" |]
    let useFunc = shiftDown arr2D 5
    Assert.Equal(arr2DCorrect, useFunc)


[<Fact>]
let ``sumLeft Test`` () =
    let arr2D = createArr ()

    let arr2DCorrect = Array2D.create 5 5 ""
    arr2DCorrect.[0, *] <- [| ""; "4"; ""; "8"; "4" |]
    arr2DCorrect.[1, *] <- [| "4"; ""; ""; "8"; "4" |]
    arr2DCorrect.[3, *] <- [| ""; ""; "16"; ""; "" |]
    arr2DCorrect.[4, *] <- [| "2"; "4"; "16"; ""; "4" |]
    let useFunc = sumLeft arr2D 5
    Assert.Equal(arr2DCorrect, useFunc)

[<Fact>]
let ``sumRight Test`` () =
    let arr2D = createArr ()

    let arr2DCorrect = Array2D.create 5 5 ""
    arr2DCorrect.[0, *] <- [| ""; "4"; ""; "8"; "4" |]
    arr2DCorrect.[1, *] <- [| "4"; ""; ""; "8"; "4" |]
    arr2DCorrect.[3, *] <- [| ""; ""; ""; "16"; "" |]
    arr2DCorrect.[4, *] <- [| "2"; "4"; ""; "16"; "4" |]
    let useFunc = sumRight arr2D 5
    Assert.Equal(arr2DCorrect, useFunc)

[<Fact>]
let ``sumUp Test`` () =
    let arr2D = createArr ()

    let arr2DCorrect = Array2D.create 5 5 ""
    arr2DCorrect.[0, *] <- [| ""; "4"; ""; "16"; "8" |]
    arr2DCorrect.[1, *] <- [| "4"; ""; ""; ""; "" |]
    arr2DCorrect.[2, *] <- [| ""; ""; ""; ""; "" |]
    arr2DCorrect.[3, *] <- [| ""; ""; "16"; "16"; "" |]
    arr2DCorrect.[4, *] <- [| "2"; "4"; ""; ""; "4" |]
    let useFunc = sumUp arr2D 5
    Assert.Equal(arr2DCorrect, useFunc)

[<Fact>]
let ``sumDown Test`` () =
    let arr2D = createArr ()

    let arr2DCorrect = Array2D.create 5 5 ""
    arr2DCorrect.[0, *] <- [| ""; "4"; ""; ""; "" |]
    arr2DCorrect.[1, *] <- [| "4"; ""; ""; "16"; "8" |]
    arr2DCorrect.[2, *] <- [| ""; ""; ""; ""; "" |]
    arr2DCorrect.[3, *] <- [| ""; ""; ""; ""; "" |]
    arr2DCorrect.[4, *] <- [| "2"; "4"; "16"; "16"; "4" |]
    let useFunc = sumDown arr2D 5
    Assert.Equal(arr2DCorrect, useFunc)
