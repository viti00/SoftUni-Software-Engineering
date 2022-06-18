function getFibonator(){
    debugger;
    let currnumber = 0;
    let nextNumber = 1;
    let fibonaci = 0;
    let counter = 0;

    function calc(){
        if(counter === 0){
            fibonaci = 1;
            counter++;
            return fibonaci;
        }
        fibonaci = currnumber + nextNumber;
        let token = currnumber + nextNumber;
        currnumber = nextNumber;
        nextNumber = token;
        return fibonaci;
    }

    return calc;
}


let fib = getFibonator();
console.log(fib()); // 1
console.log(fib()); // 1
console.log(fib()); // 2
console.log(fib()); // 3
console.log(fib()); // 5
console.log(fib()); // 8
console.log(fib()); // 13
