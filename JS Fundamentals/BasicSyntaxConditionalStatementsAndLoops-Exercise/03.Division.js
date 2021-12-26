function devisible(input){
    let number = Number(input);

    let maxDivisible = 0;

    if (number % 2 == 0){
        maxDivisible = 2;
    }
    if (number % 3 == 0){
        maxDivisible = 3;
    }
    if (number % 6 == 0){
        maxDivisible = 6;
    }
    if (number % 7 == 0){
        maxDivisible = 7;
    }
    if (number % 10 == 0){
        maxDivisible = 10;
    }

    if (maxDivisible > 0){
        console.log(`The number is divisible by ${maxDivisible}`);
    }
    else{
        console.log(`Not divisible`);
    }
}

devisible("30");