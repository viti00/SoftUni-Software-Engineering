function solve(input){
    let result = [];
    let n = input.length;
    debugger

    for (let i = 0; i < n; i++) {
        if(i % 2 == 0){
            let index = input.indexOf(Math.min(...input));
            let element = input.splice(index, 1);

            result.push(element[0]);
        }
        else if (i % 2 == 1){
            let index = input.indexOf(Math.max(...input));
            let element = input.splice(index, 1);

            result.push(element[0]);
        }
    }

    return result;
}

console.log(solve([1, 65, 3, 52, 48, 63, 31, -3, 18, 56]));