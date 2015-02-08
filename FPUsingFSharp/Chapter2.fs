module Chapter2
    
    // 2.1
    let f x = 
        (x % 2 = 0 || x % 3 = 0) && not(x % 5 = 0);;

    // 2.2
    let rec pow = function
        | (s,0) -> ""
        | (s,n) -> s + pow(s,n-1)

    // 2.3
    let isIthChar (s:string, i, c) = i >= 0 && i < s.Length && s.[i] = c

    // 2.4
    let rec occFromIth = function
        | (s:string,i,c) when i >= s.Length -> 0
        | (s,i,c)        when s.[i] = c     -> occFromIth(s, i+1, c) + 1
        | (s,i,c)                           -> occFromIth(s, i+1, c)

    // 2.5
    let occInString (s,c) = occFromIth (s,0, c)

    // 2.6
    let notDivisible (d, n) = n % d <> 0

    // 2.7 Prime Numbers

    // there is an issue here that if you call it with b > a to start it will fail.
    // but that is only because there isn't content on dealing with invalid arguments
    // yet. that's the reason for the last clause
    let rec test = function 
        | (a,b,c) when b > a -> notDivisible(a,c) && test(a+1, b, c)
        | (a,b,c) when b = a -> true 
        | (a,b,c)            -> true // should be an error 

    let isPrime = function
        | 1 -> true
        | 2 -> true
        | n -> test(2, n-1, n)

    let rec nextPrime n =
        let prime = isPrime(n)
        if prime then
            n
        else
            nextPrime(n+1)
            
    // 2.8 Binomial Coefficients
    let rec bin = function
        | (a,0) -> 1
        | (a,b) when a = b -> 1
        | (a,b) when a <> 0 && b <> 0 && a > b-> bin(a-1, b-1) + bin(a-1,b)


    // 2.9
    let rec f2 = function
        | (0,y) -> y
        | (x,y) -> f2(x-1, x*y)

    // 1. Type is: int * int -> int
    // 2. Terminates if x > 0
    // 3. f(2,3):
    //      f(2,3) -> f(1, 6)
    //      f(1,6) -> f(0, 6)
    //      f(0,6) -> 6
    // 4. Mathematical meaning is: n * n!

    // 2.10
    let test2(c,e) = if c then e else 0

    // 1. Type is: (bool * int) => int
    // 2. test(false, fact(-1)) is 0 (rather than a runtime error as e is never evaluated
    // 3. see above

    // 2.11
    let VAT percent value:float = (float(percent)/100.0 * value) + value
    let unVAT percent taxedValue:float = taxedValue / (1.0 + (float(percent)/100.0))

    // 2.12

