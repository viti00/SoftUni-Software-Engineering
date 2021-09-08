function factorial(input){
    let number = Number(input[0]);

    let result = 1;

    for (let index = 1; index <= number; index++) {
        
        result *= index;
    }

    console.log(result);
}

factorial(["5"]);