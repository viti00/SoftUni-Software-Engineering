function solve(firstNum, secondNum){
    let result = 0;

    let n = Number(firstNum);
    let m = Number(secondNum);
    for (let i = n; i <= m; i++) {
        result += i;
    }

    console.log(result);
}

solve('1', '5')