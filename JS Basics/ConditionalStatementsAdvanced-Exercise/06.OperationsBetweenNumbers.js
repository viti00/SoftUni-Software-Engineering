function operationBetweenNumbers(input){
    let a = Number(input[0]);
    let b = Number(input[1]);
    let operator = input[2];

    let result = 0.0;
    let evenOrOdd = "";
    let output = "";

    switch(operator){
        case"+":
            result = a + b;
            symbol = "+";
            if (result % 2 == 0){
                evenOrOdd = "even";
            }
            else{
                evenOrOdd = "odd";
            }
            output = `${a} ${operator} ${b} = ${result} - ${evenOrOdd}`;
        break;
        case"-":
            result = a - b;
            symbol = "-";
            if (result % 2 == 0){
                evenOrOdd = "even";
            }
            else{
                evenOrOdd = "odd";
            }
            output = `${a} ${operator} ${b} = ${result} - ${evenOrOdd}`;
        break;
        case"*":
        result = a * b;
            symbol = "*";
            if (result % 2 == 0){
                evenOrOdd = "even";
            }
            else{
                evenOrOdd = "odd";
            }
            output = `${a} ${operator} ${b} = ${result} - ${evenOrOdd}`;
        break;
        case"%":
            if (b != 0){
                result = a % b;
                output = `${a} % ${b} = ${result}`;
            }
            else{
                output = `Cannot divide ${a} by zero`;
            }
        break;
        case"/":
        if (b != 0){
                result = a / b;
                output = `${a} / ${b} = ${result.toFixed(2)}`;
            }
            else{
                output = `Cannot divide ${a} by zero`;
            }
        break;
    }
    console.log(output);
}

operationBetweenNumbers(["10", "0", "%"]);