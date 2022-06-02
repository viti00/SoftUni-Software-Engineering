function solve(firstNum, secondNum){
    debugger;
    while(secondNum){
        let t = secondNum;
        secondNum = firstNum % secondNum;
        firstNum = t;
    }

    console.log(firstNum);
}


solve(2154, 458)