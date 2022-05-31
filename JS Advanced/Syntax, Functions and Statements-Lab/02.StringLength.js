function solve(first, second, third){

    let totalLength = first.length + second.length + third.length;

    let average = totalLength/ arguments.length;

    console.log(totalLength);
    console.log(Math.floor(average));

}

solve('chocolate', 'ice cream', 'cake')
solve('pasta', '5', '22.3')