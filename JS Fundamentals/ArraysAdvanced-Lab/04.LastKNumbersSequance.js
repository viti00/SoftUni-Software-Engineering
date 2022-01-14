function lastKNumbers(arg1, arg2){

    let n = arg1;
    let k = arg2;

    let arr = [1];

    for (let i = 0; i < n - 1; i++) {
        let currElement = arr[i];
        for (let j = i - 1; j > i - k; j--) {
            if(j < 0){
                break;
            }
            currElement += arr[j];
        }

        arr.push(currElement);
    }

    console.log(arr.join(' '));
}

lastKNumbers(8, 2);