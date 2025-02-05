# F# Immutability Error: Reassigning a Non-Mutable Variable

This example demonstrates a common error in F# related to immutability.  In F#, values are immutable by default. This means that once a variable is assigned a value, it cannot be reassigned.  Attempting to change the value of a non-mutable variable results in a compile-time error.

The `bug.fs` file contains code that demonstrates this error. The `bugSolution.fs` file shows how to correct the issue by declaring the variables as mutable.

This is a crucial concept in F# programming, as it helps to ensure that code is predictable and less prone to errors. Understanding immutability is essential for writing robust and maintainable F# applications.