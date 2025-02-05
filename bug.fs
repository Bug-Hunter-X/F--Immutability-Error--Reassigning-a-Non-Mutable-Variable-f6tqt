let mutable x = 10
let mutable y = 20

let add x y = x + y

let result = add x y
printfn "%d" result

x <- 100
y <- 200

result <- add x y //Error: This will cause a compile-time error because 'result' is not mutable.
printfn "%d" result