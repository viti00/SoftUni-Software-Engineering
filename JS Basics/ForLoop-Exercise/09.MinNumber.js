function minNumber(input){
    let count = Number(input.shift());
    let min = input[0];

    for (let index = 1; index < count; index++) {
        let num = Number(input[index]);

        if(num < min){
            min = num;
        }
        
    }
    console.log(min);
}

minNumber(["2", "1000", "99"]);