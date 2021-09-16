function vacantion(input){
    let cost = Number(input.shift());
    let jessyMoney = Number(input.shift());
    let spendCount = 0;
    let days = 0;

    while(true){
        let operationType = input.shift();
        let money = Number(input.shift());
        days++;

        switch(operationType){
            case"spend":
                if (jessyMoney <= money){
                    jessyMoney -= money;
                    if (jessyMoney < 0){
                        jessyMoney = 0;
                    }
                }
                else {
                    jessyMoney -= money;
                }
                spendCount++;
            break;
            case"save":
                jessyMoney += money;
                spendCount = 0;
            break;
        }

        if (spendCount == 5){
            console.log(`You can't save the money.`)
            console.log(days);
            break;
        }
        else if (jessyMoney >= cost){
            console.log(`You saved the money for ${days} days.`);
            break;
        }
    }
}

vacantion(["2000", "1000", "spend", "1200", "save", "2000"]);