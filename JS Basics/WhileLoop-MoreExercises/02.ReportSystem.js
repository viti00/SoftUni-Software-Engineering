function reportSystem(input){
    debugger;
    let neededMoney = Number(input.shift());

    let currMoney = 0;

    let counter = 1;

    let command = input.shift();

    let payWithCard = 0;
    let payInCash = 0;

    let cardTransactCount = 0;
    let cashTransactCount = 0;


    while(command != "End" && currMoney < neededMoney){
        let productPrice = Number(command);
        
        if (counter % 2 == 1){
            if (productPrice > 100){
                console.log("Error in transaction!");
            }
            else {
                cashTransactCount++;
                payInCash += productPrice;
                currMoney += productPrice;
                console.log("Product sold!");
            }
        }
        else if (counter % 2 == 0){
            if (productPrice  < 10){
                console.log("Error in transaction!");
            }
            else {
                cardTransactCount++;
                payWithCard += productPrice;
                currMoney += productPrice;
                console.log("Product sold!");
            }
        }

        counter++;
        command = input.shift();
    }

    if (currMoney >= neededMoney){
        let averageCash = payInCash / cashTransactCount;
        let averageCard = payWithCard / cardTransactCount;
        console.log(`Average CS: ${averageCash.toFixed(2)}`);
        console.log(`Average CC: ${averageCard.toFixed(2)}`);
    }
    else {
        console.log(`Failed to collect required money for charity.`);
    }
}

reportSystem(["500", "120", "8", "63", "256","78", "317"]);