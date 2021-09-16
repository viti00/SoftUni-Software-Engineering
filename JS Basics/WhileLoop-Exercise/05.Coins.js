function coins(input){
    let money = Number(input.shift());

    let moneyInCents = money * 100;
    let centsCount = 0;
    let totalCents = 0;

    while(moneyInCents > 0){
        if (moneyInCents >= 200){
            centsCount = parseInt(moneyInCents / 200);

            moneyInCents -= centsCount * 200;
        }
        else if (moneyInCents >= 100 && moneyInCents <= 199){
            centsCount = parseInt(moneyInCents / 100);

            moneyInCents -= centsCount * 100;
        }
        else if (moneyInCents >= 50 && moneyInCents <= 99){
            centsCount = parseInt(moneyInCents / 50);

            moneyInCents -= centsCount * 50;
        }
        else if (moneyInCents >= 20 && moneyInCents <= 49){
            centsCount = parseInt(moneyInCents / 20);

            moneyInCents -= centsCount * 20;
        }
        else if (moneyInCents >= 10 && moneyInCents <= 19){
            centsCount = parseInt(moneyInCents / 10);

            moneyInCents -= centsCount * 10;
        }
        else if (moneyInCents >= 5 && moneyInCents <= 9){
            centsCount = parseInt(moneyInCents / 5);

            moneyInCents -= centsCount * 5;
        }
        else if (moneyInCents >= 2 && moneyInCents <= 4){
            centsCount = parseInt(moneyInCents / 2);

            moneyInCents -= centsCount * 2;
        }
        else if (moneyInCents == 1){
            centsCount = parseInt(moneyInCents / 1);

            moneyInCents -= centsCount * 1;
        }
        totalCents += centsCount;
    }

    console.log(totalCents);
}

coins(["0"]);