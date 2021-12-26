function printAndSum(arg1, arg2){
    let startIndex = Number(arg1);
    let endIndex = Number(arg2);
    let result = "";
    let sum = 0;

    for (let i = startIndex; i <= endIndex; i++) {
        result += `${i} `;
        sum += i;
    }

    console.log(result);
    console.log(`Sum: ${sum}`);
}

printAndSum("5", "10");