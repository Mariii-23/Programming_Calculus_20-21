module FSharp.Compatibility.Haskell.Prelude


let either f g = function Left x -> f x | Right y -> g y


// Functors
let inline fmap f x = map f x
