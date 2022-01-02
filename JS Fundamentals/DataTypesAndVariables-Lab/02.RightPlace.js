function rightPlace(arg1, arg2, arg3){

    let firstString = arg1;
    let char = arg2;
    let secondString = arg3;

    let result = firstString.replace('_', char);
    
    if (result === secondString){
        console.log(`Matched`);
    }
    else {
        console.log(`Not Matched`);
    }
}

rightPlace("str_ng", "i", "strong");