function addAndSubstract(arr){
    let originalArrSum = 0
    let newArrSum = 0;
    let newArr = [];

    for (let i = 0; i < arr.length; i++) {
        let num = 0;
        if(arr[i] % 2 == 0){
            num = arr[i] + i;
        }
        else{
           num = arr[i] - i;
        }

        newArr.push(num);
        
    }
    debugger;
    for (let j = 0; j < arr.length; j++) {
        originalArrSum += arr[j];
        newArrSum += newArr[j];
        
    }

    console.log(`[ ${newArr.join(", ")} ]`);
    console.log(originalArrSum);
    console.log(newArrSum);
}

addAndSubstract([5, 15, 23, 56, 35]);