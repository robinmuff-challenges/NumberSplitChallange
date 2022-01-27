let input = "1 1 5 9 8 1 3 5 8 1 1 8 7 5 6 1 2 9  1 2 5 8 0 2"
let output = ""
let numbers = input.split(" ")

let stringNumber = ""
numbers.forEach((num) => {
    if (stringNumber + num.toString() > 120) {
        output += stringNumber.toString() + " "
        stringNumber = ""
    }
    stringNumber += num.toString()
})

console.log(output)