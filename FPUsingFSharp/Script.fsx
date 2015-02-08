// Learn more about F# at http://fsharp.net. See the 'F# Tutorial' project
// for more guidance on F# programming.

#load "Chapter1.fs"

Chapter1.g 10
Chapter1.h 11.0 12.0
Chapter1.h1 (11.0, 12.0)

Chapter1.fib 10
Chapter1.fib 11
Chapter1.fib 12

seq { for i in 1..13 -> i } 
    |> Seq.iter (fun i -> printf "Chapter%i.fs\n" i);
