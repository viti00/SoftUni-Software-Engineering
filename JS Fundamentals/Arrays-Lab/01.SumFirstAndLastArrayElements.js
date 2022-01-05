function sumElements(input){

    let firstNum = Number(input.shift());
    let lastNum = Number(input[input.length - 1]);

    let sum = firstNum + lastNum;

    console.log(sum);
}

sumElements([20, 30, 40]);