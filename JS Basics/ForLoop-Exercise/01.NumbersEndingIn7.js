function numbersEnding7(){

    for (let index = 1; index <= 1000; index ++) {
        let digit = index % 10;
        if (digit == 7){
            console.log(index);
        }
    }
}

numbersEnding7();