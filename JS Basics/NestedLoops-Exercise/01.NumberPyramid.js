function pyramidNumber(input){
    let number = Number(input.shift());
    let output = "";
    let isBigger = false;
    let currNum = 1;

    for (let row = 1; row <= number ; row++) {
        
        for (let col = 1; col <= row; col++) {
            if (currNum > number){
                isBigger = true;
                break;
            }
           output += currNum + " "; 
           currNum++;
        }

        console.log(output);
        if (isBigger == true){
            break;
        }
        output = "";
    }
}

pyramidNumber(["7"]);