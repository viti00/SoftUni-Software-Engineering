function equalSums(arr){

    let isEqual = false;
    let index = 0;
    for (let i = 0; i < arr.length; i++) {
        let leftSum = 0;
        let rightSum = 0;
        for (let j = i; j >= 0; j--) {
            leftSum  += arr[j];
        }
        for (let k = i; k < arr.length; k++) {
            rightSum += arr[k];
        }

        if (leftSum == rightSum){
            isEqual = true;
            index = i;
            break;
        }
    }
    if (arr.length <= 1){
        console.log(0);
    }
    else if (isEqual == true){
        console.log(index);
    }
    else if (isEqual == false){
        console.log("no");
    }
}

equalSums([1,2,3,3]);