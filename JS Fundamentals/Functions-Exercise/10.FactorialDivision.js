function factorialDivision(arg1, arg2){
    let firstNum = Number(arg1);
    let secondNum = Number(arg2);

    let firstFactorial = factorial(firstNum);

    let secondFactorial = factorial(secondNum);

    let divisionResult = division(firstFactorial, secondFactorial);

    console.log(divisionResult.toFixed(2));


    function factorial(num){
        let sum = 1;

        for (let i = 1; i <= num; i++) {
            sum *= i;
        }

        return sum;
    }

    function division(first, second){
        return first / second;
    }
}

factorialDivision("5", "2");