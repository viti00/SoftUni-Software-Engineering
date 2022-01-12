function addAndSubtract(arg1, arg2, arg3){

    let adedSum = sum(arg1, arg2);

    console.log(subtract(adedSum, arg3));

    function sum(arg1, arg2){
        return arg1 + arg2;
    }
    function subtract(addedSum, arg3){
        return addedSum - arg3;
    }
}

addAndSubtract(23, 6, 10);