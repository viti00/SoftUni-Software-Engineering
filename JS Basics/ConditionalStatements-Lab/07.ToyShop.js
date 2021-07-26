function calculate(input){
    let excursionPrice = Number(input[0]);
    let puzzles = Number(input[1]);
    let speakDolls = Number([input[2]]);
    let bears = Number(input[3]);
    let minions = Number(input[4]);
    let trucks = Number(input[5]);

    let puzzelPrice = 2.60;
    let speakDollPrice = 3.00;
    let bearPrice = 4.10;
    let minionPrice = 8.20;
    let truckPrice = 2.00;
    
    let totalToysCount = puzzles + speakDolls + bears + minions + trucks;
    
    let sum = puzzelPrice * puzzles + speakDolls * speakDollPrice + bears * bearPrice + minions * minionPrice + trucks * truckPrice;

    if (totalToysCount >= 50){
        sum -= sum * 0.25;
    }

    let profit = sum - sum * 0.10;

    if (profit >= excursionPrice){
        let residue = profit - excursionPrice;
        console.log(`Yes! ${residue.toFixed(2)} lv left.`);
    }
    else {
        let needed = excursionPrice - profit;
        console.log(`Not enough money! ${needed.toFixed(2)} lv needed.`)
    }

}

calculate(["40.8", "20", "25", "30", "50", "10"]);