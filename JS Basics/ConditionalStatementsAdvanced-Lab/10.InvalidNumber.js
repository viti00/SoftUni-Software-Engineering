function invalidNumber(input){
    let num = Number(input[0]);

    if (num < 100 || num > 200){
        if(num != 0){
            console.log("invalid");
        }
    }
}

invalidNumber(["0"]);