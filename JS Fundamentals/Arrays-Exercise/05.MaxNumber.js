function maxNumber(arr){
    debugger;
    let isBigger = true;
    let result = "";
    for (let i = 0; i < arr.length; i++) {
        let currNum = arr[i];
        for (let j = i + 1; j < arr.length; j++) {
            if (currNum <= arr[j]){
                isBigger = false;
                break;
            }
        }

        if (isBigger == true){
            result += currNum + " ";
        }
        isBigger = true;
    }

    console.log(result);
}

maxNumber([1, 4, 3, 2]);