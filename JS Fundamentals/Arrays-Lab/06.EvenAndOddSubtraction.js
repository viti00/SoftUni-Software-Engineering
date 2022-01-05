function evenAndOddSubstraction(arr){

    let evenSum = 0;
    let oddSum = 0;

    for (const el of arr) {
        if (el % 2 == 0){
            evenSum += el;
        }
        else {
            oddSum += el;
        }
    }

    console.log(evenSum - oddSum);
}

evenAndOddSubstraction([1,2,3,4,5,6]);