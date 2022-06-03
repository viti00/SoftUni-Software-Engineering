function solve(arr, firstPie, lastPie){
    let startIndex = arr.indexOf(firstPie);
    let endIndex = arr.indexOf(lastPie);

    let result = arr.slice(startIndex, endIndex + 1);

    return result;
}

console.log(solve(['Pumpkin Pie',
'Key Lime Pie',
'Cherry Pie',
'Lemon Meringue Pie',
'Sugar Cream Pie'],
'Key Lime Pie',
'Lemon Meringue Pie'
));