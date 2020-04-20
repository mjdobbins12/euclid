module Euclid

open System

let rec euclid (num1: int) (num2: int) = 
    match abs(num1 - num2) with
    | 0 -> num2
    | _ -> euclid num2 (abs(num1 - num2))
