function maxNumber(input){
    let i = 0;

    let maxNumber = Number(input.shift());

    let command = input.shift();

    while(command != "Stop"){
        let currNum = Number(command);

        if (currNum > maxNumber){
            maxNumber = currNum;
        }

        command = input[i];
        i++;
    }

    console.log(maxNumber);
}

maxNumber(["10", "9", "81", "Stop"]);