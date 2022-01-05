function equalArrays (arr1, arr2){

    for (let i = 0; i < arr1.length; i++) {
        arr1[i] = Number(arr1[i]);
        arr2[i] = Number(arr2[i]);
    }

    let isEqual = true;
    let diffIndex = 0;

    for (let j = 0; j < arr1.length; j++) {
        if(arr1[j] != arr2[j]){
            isEqual = false;
            diffIndex = j;
            break;
        }
        
    }

    if(isEqual == true){
        let sum = 0;
        for (const el of arr1) {
            sum += el;
        }
        console.log(`Arrays are identical. Sum: ${sum}`);
    }
    else{
        console.log(`Arrays are not identical. Found difference at ${diffIndex} index`);
    }
}

equalArrays(['1','2','3','4','5'], ['1','2','4','4','5']);