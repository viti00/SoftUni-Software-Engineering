function simpleCalculator(arg1, arg2, arg3){
    let firstNum = Number(arg1);
    let secondNum = Number(arg2);
    let action = arg3;

    console.log(calculation(firstNum, secondNum, action));

    function calculation(firstNum, secondNum, action){
        let result = 0;
        switch (action) {
            case "multiply":
                result = firstNum * secondNum;
                break;
            case"divide":
                result = firstNum / secondNum;
                break;
            case"add": 
                result = firstNum + secondNum;
                break;
            case"subtract":
                result = firstNum - secondNum;
                break;
        }
        return result;
    }
}

simpleCalculator("5", "5", "multiply");