function sortNumbers(arg1, arg2, arg3) {
    debugger;
    let firstNum = Number(arg1);
    let secondNum = Number(arg2);
    let thirdNum = Number(arg3);
    if (firstNum >= secondNum && firstNum >= thirdNum) {

        if (secondNum >= thirdNum) {
            console.log(firstNum);
            console.log(secondNum);
            console.log(thirdNum);
        }
        else if (thirdNum >= secondNum) {
            console.log(firstNum);
            console.log(thirdNum);
            console.log(secondNum);
        }

    }
    else if (secondNum >= firstNum && secondNum >= thirdNum) {

        if (firstNum >= thirdNum) {
            console.log(secondNum);
            console.log(firstNum);
            console.log(thirdNum);
        }
        else if (thirdNum >= firstNum) {
            console.log(secondNum);
            console.log(thirdNum);
            console.log(firstNum);
        }

    }
    else if (thirdNum >= firstNum && thirdNum >= secondNum) {

        if (firstNum >= secondNum) {
            console.log(thirdNum);
            console.log(firstNum);
            console.log(secondNum);
        }
        else if (secondNum >= firstNum) {
            console.log(thirdNum);
            console.log(secondNum);
            console.log(firstNum);
        }

    }
}
sortNumbers("0", "2", "0");