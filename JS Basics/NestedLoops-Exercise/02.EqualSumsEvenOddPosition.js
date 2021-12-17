function solve(input){
    let startIndex = Number(input.shift());
    let endIndex = Number(input.shift());
    


    let result = "";

    for (let index = startIndex; index <= endIndex; index++) {
        let oddSum = 0;
        let evenSum = 0;
        let numbersSequence = index.toString();

        for (let i = 0; i <= numbersSequence.length - 1; i++) {
            if(i % 2 == 1){
                oddSum += Number(numbersSequence[i]);
            }
            else if (i % 2 == 0){
                evenSum += Number(numbersSequence[i]);
            }
        }
        if (evenSum == oddSum){
            result += numbersSequence + " ";
        }

    }

    console.log(result);
}

solve(["100000", "100050"]);