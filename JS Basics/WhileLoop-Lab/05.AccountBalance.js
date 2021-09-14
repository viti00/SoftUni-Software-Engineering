function accountBalance(input){
    let i = 0;

    let command = input.shift();

    let total = 0.0;
    while(command != "NoMoreMoney"){

        let sum = Number(command);

        if (sum < 0){
            console.log("Invalid operation!")
            break;
        }


        total += sum;
        console.log(`Increase: ${sum.toFixed(2)}`);
        command = input[i];
        i++;
    }

    console.log(`Total: ${total.toFixed(2)}`);
    
}

accountBalance(["5", "10", "-2"]);