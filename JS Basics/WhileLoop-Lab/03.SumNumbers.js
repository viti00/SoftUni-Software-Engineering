function sumNumbers(input){
    let number = Number(input.shift());

    let sum = 0;
    let i = 0;

    while(sum < number){
        let currNum = Number(input[i]);

        sum += currNum;

        i++;
    }

    console.log(sum);
}

sumNumbers(["10", "2", "3", "4", "1","2"])