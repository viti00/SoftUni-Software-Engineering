function reverseAnArray(arg1, arr){
    let n = Number(arg1);

    let newArray = [];
    for (let i = 0; i < n; i++) {
        
        newArray.push(arr[i]);
    }

    newArray = newArray.reverse();
    let result = "";

    for (let j = 0; j < newArray.length; j++) {
        
        result += newArray[j] + " ";
    }

    console.log(result);
}

reverseAnArray("3", [10, 20, 30, 40, 50]);