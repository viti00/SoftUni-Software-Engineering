function traveling(input){
    debugger;
    let command = input.shift();

    let savedMoney = 0;

    let destination = "";

    while(command !="End"){
        destination = command;
        let minBudget = Number(input.shift());

        while(savedMoney < minBudget){
            let money = Number(input.shift());
            savedMoney += money;
        }

        console.log(`Going to ${destination}!`);
        savedMoney = 0;

        command = input.shift();
    }
}

traveling(["Greece", "1000", "500", "700", "Spain", "700", "350", "350", "End"]);