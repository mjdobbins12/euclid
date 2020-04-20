module Euclid

open System

let rec euclid (num1: int) (num2: int) = 
    match num1 - num2 with
    | x when x < 0 -> None
    | 0 -> Some num2
    | _ -> euclid num2 (num1 - num2)