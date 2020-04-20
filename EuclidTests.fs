module EuclidTests

open FsUnit.Xunit
open Xunit

open Euclid

[<Fact>]
let ``GCD of a number and itself is itself`` () =
    euclid 12 12 |> should equal (Some 12)
