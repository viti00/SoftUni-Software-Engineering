function calculator(arg1, arg2, arg3){
    let firstNum = Number(arg1);
    let symbol = arg2;
    let SecondNum = Number(arg3);
    let result = 0;

    if (symbol == "*"){
        result = firstNum * SecondNum;
    }
    else if (symbol == "/"){
        result = firstNum / SecondNum;
    }
    else if (symbol == "+"){
        result = firstNum + SecondNum;
    }
    else if (symbol == "-"){
        result = firstNum - SecondNum;
    }
    else if (symbol == "%"){
        result = firstNum % SecondNum;
    }

    console.log(result.toFixed(2));
}

calculator("5", "+", "6");