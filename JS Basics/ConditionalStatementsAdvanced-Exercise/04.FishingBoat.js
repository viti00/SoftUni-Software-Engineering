function fishingBoat(input){
    let budget = Number(input[0]);
    let season = input[1];
    let fishermanCount = Number(input[2]);

    let springBoatPrice = 3000;
    let summerAndAutumnBoatPrice = 4200;
    let winterBoatPrice = 2600;

    let cost = 0.0;
    if(season == "Spring"){
        if (fishermanCount <= 6){
            cost = springBoatPrice * 0.90;
        }
        else if (fishermanCount >= 7 && fishermanCount <= 11){
            cost = springBoatPrice * 0.85;
        }
        else if (fishermanCount >= 12){
            cost = springBoatPrice * 0.75;
        }
    }
    else if (season == "Summer" || season == "Autumn"){
        if (fishermanCount <= 6){
            cost = summerAndAutumnBoatPrice * 0.90;
        }
        else if (fishermanCount >= 7 && fishermanCount <= 11){
            cost = summerAndAutumnBoatPrice * 0.85;
        }
        else if (fishermanCount >= 12){
            cost = summerAndAutumnBoatPrice * 0.75;
        }
    }
    else if (season == "Winter"){
        if (fishermanCount <= 6){
            cost = winterBoatPrice * 0.90;
        }
        else if (fishermanCount >= 7 && fishermanCount <= 11){
            cost = winterBoatPrice * 0.85;
        }
        else if (fishermanCount >= 12){
            cost = winterBoatPrice * 0.75;
        }
    }

    if (fishermanCount % 2 == 0){
        if (season == "Summer" || season == "Spring" || season == "Winter"){
            cost = cost * 0.95;
        }
    }

    if (cost > budget){
        let need = cost - budget;
        console.log(`Not enough money! You need ${need.toFixed(2)} leva.`);
    }
    else {
        let left = budget - cost;
        console.log(`Yes! You have ${left.toFixed(2)} leva left.`);
    }
}

fishingBoat(["2000", "Winter", "13"]);