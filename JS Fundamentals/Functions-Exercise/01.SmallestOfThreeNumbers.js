function smallestNumber(arg1, arg2, arg3){
    let smallestNum = 0;

    if (arg1 <= arg2 && arg1 <= arg3){
        smallestNum = arg1;
    }
    else if (arg2 <= arg1 && arg2 <= arg3){
        smallestNum = arg2;
    }
    else if (arg3 <= arg1 && arg3 <= arg2){
        smallestNum = arg3;
    }

    console.log(smallestNum);

}

smallestNumber(2, 2, 3);