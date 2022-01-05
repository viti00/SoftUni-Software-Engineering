function condenseArrayToNumbers(arr){
    debugger;
    
    while(arr.length > 1){
        let newArr = [];
        for (let i = 0; i < arr.length - 1; i++) {
            let currSum = arr[i] + arr[i + 1];
            newArr.push(currSum);
            arr[i] = currSum;
        }
        arr = newArr;
    }

    console.log(arr[0]);
}
condenseArrayToNumbers([5,0,4,1,2]);