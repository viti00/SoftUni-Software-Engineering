function integerAndFloat(arg1, arg2, arg3){
    let firstNum = Number(arg1);
    let secondNum = Number(arg2);
    let thirdNum = Number(arg3);

    let sum = firstNum + secondNum + thirdNum;

    if (sum % 1 == 0){
        console.log(`${sum} - Integer`)
    }
    else {
        console.log(`${sum} - Float`);
    }
}

integerAndFloat("1", "2", "3");