function sumEvenNumbers(arr){

    for (let i = 0; i < arr.length; i++) {
        arr[i] = Number(arr[i]);
    }

    let sum = 0;
    for (const el of arr) {
        if(el % 2 == 0){
            sum += el;
        }
    }

    console.log(sum);
}

sumEvenNumbers(['1','2','3','4','5','6']);