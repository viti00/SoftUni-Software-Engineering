function equalPairs(input){
    let n = Number(input.shift());
    let firstNum = Number(input.shift());
    let secondNum = Number(input.shift());
    let count = 1;
    let diff = 0;
    let sum = firstNum + secondNum;

    for (let index = 0; index < (n  * 2) - 2; index += 2) {
        let first = Number(input[index]);
        let second = Number(input[index + 1]);

        let currSum = first + second;
        
        if (sum == currSum){
            count++;
        }
        else {
            let currDiff = Math.abs(sum - currSum);
            if (currDiff > diff){
                diff = currDiff;
            }
        }

        sum = currSum;
    }

    if (count == n){
        console.log(`Yes, value=${sum}`);
    }
    else {
        console.log(`No, maxdiff=${diff}`);
    }
}

equalPairs(["1","5","5"]);