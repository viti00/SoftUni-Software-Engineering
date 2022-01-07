function mergeArays(arr1, arr2){

    let newArr = [];
    for (let i = 0; i < arr1.length; i++) {
        if(i % 2 == 0){
            let firstNum = Number(arr1[i]);
            let secondNum = Number(arr2[i]);

            let sum = firstNum + secondNum;

            newArr.push(sum.toString());
        }
        else{
            let result = `${arr1[i]}${arr2[i]}`;
            newArr.push(result);
            
        }
    }

    console.log(newArr.join(" - "));
}

mergeArays(['5', '15', '23', '56', '35'],['17', '22', '87', '36', '11']);