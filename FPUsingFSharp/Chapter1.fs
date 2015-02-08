// Chapter 1

module Chapter1
    // 1.1
    let g n = n + 10

    // 1.2
    let h x y = System.Math.Sqrt(x*x + y*y)

    // 1.3
    let g1 = function
        n -> n + 10

    let h1 = function
        (x,y) -> System.Math.Sqrt(x*x + y*y)

    // 1.4
    let rec f = function
        | 0 -> 0
        | n -> n + f(n-1)

    // 1.5
    let rec fib = function
        | 0 -> 0
        | 1 -> 1
        | n -> fib(n-1) + fib(n-2)

    // 1.6
    let rec sum = function
        | (m,0) -> m
        | (m, n) -> m + sum (m, n-1)


