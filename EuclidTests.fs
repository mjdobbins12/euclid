module EuclidTests

open FsUnit.Xunit
open Xunit

open Euclid

[<Fact>]
let ``GCD of a number and itself is itself`` () =
    euclid 12 12 |> should equal (Some 12)

[<Fact>]
let ``GCD of 18 and 12 is 6`` () =
    euclid 18 12 |> should equal (Some 6)

[<Fact>]
let ``7 and 4 have no GCD`` () =
    euclid 7 4 |> should equal None