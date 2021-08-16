function sumOfNumbers(input){
    let numbers = input[0];

    let sum = 0.0;

    for (let index = 0; index < numbers.length; index++) {
        let num = Number(numbers[index]);
        sum += num;
    }

    console.log(`The sum of the digits is:${sum}`);
}

sumOfNumbers(["1234"]);