function sorting(arr) {

    debugger;
    let descendingOrder = arr.sort((a, b) => b - a);
    let newArr = [];


    while (descendingOrder.length > 0) {
        newArr.push(descendingOrder.shift());
        newArr.push(descendingOrder.pop());
    }

    console.log(newArr.join(" "));

}

sorting([1, 21, 3, 52, 69, 63, 31, 2, 18, 94]);