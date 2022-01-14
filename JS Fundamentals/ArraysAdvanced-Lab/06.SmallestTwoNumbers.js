function smallesTwoNumber(arr){
    arr = arr.sort((a,b) => a - b).splice(0, 2);

    console.log(arr.join(" "));
}

smallesTwoNumber([30, 15, 50, 5]);