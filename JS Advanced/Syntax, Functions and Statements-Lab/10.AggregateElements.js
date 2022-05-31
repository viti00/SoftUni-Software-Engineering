function solve(param){
    debugger;

    let sumOfAllElements = 0;

    let sumOfAllElementsDivideBy1 = 0;

    let concatElement = '';

    for (let i = 0; i < param.length; i++) {
        sumOfAllElements += param[i];

        sumOfAllElementsDivideBy1 += 1/param[i];

        concatElement += param[i];
    }

    console.log(sumOfAllElements);

    console.log(sumOfAllElementsDivideBy1);

    console.log(concatElement);
}

solve([1, 2, 3])