#if INTERACTIVE
#else
module Say
#endif

//let
let x = 42
let hi = "Hello"

//if-else
let Greeting name =
    if System.String.IsNullOrEmpty(name) 
    then 
        "Whoever u r"
    else
        name

//function
let SayHiTo name =
    printfn "Hi, %s" (Greeting name)

//function
let Square x = x * x

//overriding type interence
let Area (length : float) height =
    length * height
//Tupling function arguments
let temp_Area = Area 2.0
temp_Area 3.0

//for, nesting functions
let PrintNumbers min max =
    //let Square x = x * x
    for x in min..max do
        printfn "%i %i" x (Square x)

//Returning, Decomposing Tuples
let RandomPosition() =
    let r = new System.Random()
    r.NextDouble(), r.NextDouble()
let lat, lng = RandomPosition()



