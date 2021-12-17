function specialNumber(input){
    let n = Number(input.shift());
    let counter = 0;
    let result = "";

    for (let index = 1111; index <= 9999; index++) {
        
        let number = index.toString();

        for (let i = 0; i <= number.length - 1; i++) {
            if (n % Number(number[i]) == 0 ){
                counter++;
            }
        }

        if (counter == 4){
            result += number + " ";
        }
        
        counter = 0;
    }

    console.log(result);
}

specialNumber(["3"]);