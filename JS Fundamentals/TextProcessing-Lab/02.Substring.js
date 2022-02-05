function solve(arg1, arg2, arg3){
    let string = arg1;
    let startIndex = arg2;
    let count = arg3;


    let result = string.substr(startIndex, count);

    console.log(result);
}

solve("ASentance", 1, 8);