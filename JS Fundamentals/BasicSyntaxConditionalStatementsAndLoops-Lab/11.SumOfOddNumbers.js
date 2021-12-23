function sumOfOddNumbers(number){
    let currNum = 1;
    let sum = 0;
    for (let i = 1; i <= number; i++) {
        sum += currNum;
        console.log(currNum);
        currNum +=2;
    }
    console.log(`Sum: ${sum}`);
}


sumOfOddNumbers(5);