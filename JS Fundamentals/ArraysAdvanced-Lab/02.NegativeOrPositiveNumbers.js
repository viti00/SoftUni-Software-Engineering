function negativeOrPositive(arr){

    let newArr = [];

    for (let i = 0; i < arr.length; i++) {
       let currElement = arr[i];

       if (currElement < 0){
           newArr.unshift(currElement);

       }
       else {
           newArr.push(currElement);
       }
    }

    console.log(newArr.join("\n"));
}

negativeOrPositive([7, -2, 8, 9]);

