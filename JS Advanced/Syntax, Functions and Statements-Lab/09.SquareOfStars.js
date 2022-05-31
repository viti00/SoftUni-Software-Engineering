function solve(param = 5){
    let result = '';

    for (let i = 0; i < param; i++) {
        result += '* '.repeat(param) + '\n';
        
    }

    console.log(result);
}

solve(2)