function solve(input){
    debugger;
    let result = input.filter((n, i) => i % 2 == 1).map(x=> x * 2).reverse();

    console.log(result.join(' '));
}

solve([3, 0, 10, 4, 7, 3])