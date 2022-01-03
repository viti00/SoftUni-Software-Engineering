function spiceMustFlow(arg1){
    let startingYield = Number(arg1);
    let currYield = startingYield;
    let daysCount = 0;
    let totalAmount = 0;
    while(currYield >= 100){
        daysCount++;
        totalAmount += currYield;
        if (totalAmount >= 26){
            totalAmount -= 26;
        }
        else{
            totalAmount = 0;
        }
        startingYield -= 10;
        currYield = startingYield;
    }

    if (totalAmount >= 26){
        totalAmount -= 26;
    }
    else{
        totalAmount = 0;
    }

    console.log(daysCount);
    console.log(totalAmount);
}

spiceMustFlow("111");