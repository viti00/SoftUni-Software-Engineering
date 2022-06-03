function solve(input){
    let sorted = input.sort((a,b)=> a - b);

    let result = sorted.splice(Math.floor(sorted.length / 2));

    return result;
}

console.log(solve([3, 19, 14, 7, 2, 19, 6]))