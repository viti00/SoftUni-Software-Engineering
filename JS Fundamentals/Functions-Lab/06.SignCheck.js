function singCheck(arg1, arg2, arg3){
    let firstNum = Number(arg1);
    let secondNum = Number(arg2);
    let thirdNum = Number(arg3);

    console.log(check(firstNum, secondNum, thirdNum));

    function check(x, y, z){
        let negativeCounter = 0;
        let result = "";
        if (x < 0){
            negativeCounter++;
        }
        

        if (y < 0){
            negativeCounter++;
        }
        
        if (z < 0){
            negativeCounter++;
        }
        
        if (negativeCounter % 2 == 0){
            result = "Positive";
        }
        else{
            result = "Negative";
        }

        return result;
    }
}

singCheck("5", "12", "15");