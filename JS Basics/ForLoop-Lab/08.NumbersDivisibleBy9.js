function numbersDevisibleBy9(input){
    let firstNumber = Number(input[0]);
    let secondNumber = Number(input[1]);

    let sum = 0.0;

    for (let index = firstNumber; index <= secondNumber; index++) {
        if(index % 9 == 0){
            sum += index;
        }
    }
    console.log(`The sum: ${sum}`);

    for (let index = firstNumber; index <= secondNumber; index++) {
        if(index % 9 == 0){
            console.log(index);
        }
    }
}

numbersDevisibleBy9(["100", "200"]);