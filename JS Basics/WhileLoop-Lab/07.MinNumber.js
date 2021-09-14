function minNumber(input){
    let i = 0;

    let minNumber = Number(input.shift());

    let command = input.shift();

    while(command != "Stop"){
        let currNum = Number(command);

        if (currNum < minNumber){
            minNumber = currNum;
        }

        command = input[i];
        i++;
    }

    console.log(minNumber);
}

minNumber(["10", "9", "81", "Stop"]);