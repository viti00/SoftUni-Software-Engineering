function solve(input){
    let sorted = input.sort((a,b) => a - b);

    let result = `${sorted[0]} ${sorted[1]}`;

    console.log(result);
}

solve([30, 15, 50, 5])