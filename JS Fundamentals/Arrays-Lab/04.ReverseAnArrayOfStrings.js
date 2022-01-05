function reverseAnArrayOfStings(arr){
    debugger;
    for (let i = 0; i < arr.length / 2; i++) {
        swapingElements(arr, i, arr.length - 1 - i);
    }

    console.log(arr.join(' '));

    function swapingElements(arr, i, j){
        let element = arr[i];
        arr[i] = arr[j];
        arr[j] = element;
    }
}

reverseAnArrayOfStings(['a', 'b', 'c', 'd', 'e']);