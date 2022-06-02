function solve(num){
    let numToText = String(num);

    let areAllDigitsSame = true;

    let currDigit = numToText[0];

    let sumOfDigit = Number(currDigit);

    for (let i = 1; i < numToText.length; i++) {
        if(numToText[i] !== currDigit){
            areAllDigitsSame = false;
        }

        sumOfDigit += Number(numToText[i]);
    }

    console.log(areAllDigitsSame);

    console.log(sumOfDigit);
}

solve(2222222)