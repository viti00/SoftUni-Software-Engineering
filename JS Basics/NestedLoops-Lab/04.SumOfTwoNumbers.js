function sumOfTwoNumbers(input){
    let startNumber = Number(input.shift());
    let endNumber = Number(input.shift());
    let magicNumber = Number(input.shift());
    debugger;
    let combination = 0;
    let counter = 0;

    let firstNum = startNumber;
    let secondNum = startNumber;

    for (let first = startNumber; first <= endNumber; first++) {
        
        firstNum = first;
        for (let second = startNumber; second <= endNumber; second++) {
            
            counter++;
            combination = first + second;
            secondNum = second;
            if (combination == magicNumber){
                break;
            }
            
        }
        if(combination == magicNumber){
            break;
        }
    }

    if (combination == magicNumber){
        console.log(`Combination N:${counter} (${firstNum} + ${secondNum} = ${firstNum + secondNum})`);
    }
    else {
        console.log(`${counter} combinations - neither equals ${magicNumber}`);
    }
}

sumOfTwoNumbers(["88", "888", "1000"]);