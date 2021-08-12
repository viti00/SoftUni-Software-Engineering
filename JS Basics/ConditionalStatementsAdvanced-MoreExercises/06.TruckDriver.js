function truckDriver(input){
    let season = input[0];
    let kilometersPerMonth = Number(input[1]);

    let profit = 0.0;

    if (kilometersPerMonth <= 5000){
        if (season == "Spring" || season == "Autumn"){
            profit = kilometersPerMonth * 0.75 * 4;
        }
        else if (season == "Summer"){
            profit = kilometersPerMonth * 0.90 * 4;
        }
        else if (season == "Winter"){
            profit = kilometersPerMonth * 1.05 * 4;
        }
    }
    else if (kilometersPerMonth > 5000 && kilometersPerMonth <= 10000){
        if (season == "Spring" || season == "Autumn"){
            profit = kilometersPerMonth * 0.95 * 4;
        }
        else if (season == "Summer"){
            profit = kilometersPerMonth * 1.10 * 4;
        }
        else if (season == "Winter"){
            profit = kilometersPerMonth * 1.25 * 4;
        }

    }
    else if (kilometersPerMonth > 10000 && kilometersPerMonth <= 20000){
        profit = kilometersPerMonth * 1.45 * 4;
    }

    let finalProfit = profit * 0.90;

    console.log(finalProfit.toFixed(2));
}

truckDriver(["Winter", "16042"]);