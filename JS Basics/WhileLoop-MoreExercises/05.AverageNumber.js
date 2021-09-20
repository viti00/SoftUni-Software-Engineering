function averageNumber(input){
    let n =  Number(input.shift());

    let sum = 0;

    for (let index = 0; index < n; index++) {
        
        let number = Number(input[index]);

        sum += number;
        
    }

    let average = sum / n;

    console.log(average.toFixed(2));
}

averageNumber(["4", "3", "2", "4", "2"]);
