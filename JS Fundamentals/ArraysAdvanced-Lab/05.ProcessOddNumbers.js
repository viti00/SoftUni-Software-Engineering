function processOddNumbers(arr){


    let newArr = arr.filter((x, i) => i % 2 == 1).map(x => x * 2).reverse(arr);

    console.log(newArr.join(" "));


}

processOddNumbers([3, 0, 10, 4, 7, 3]);