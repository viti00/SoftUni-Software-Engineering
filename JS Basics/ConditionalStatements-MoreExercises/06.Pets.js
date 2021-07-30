function solve(input){
    let days = Number(input[0]);
    let foodInKg = Number(input[1]);
    let dogFoodPerDayInKg = Number(input[2]);
    let catFoodPerDayInKg = Number(input[3]);
    let turtleFoodPerDayInG = Number(input[4]);

    let totalDogFood = days * dogFoodPerDayInKg;
    let totalCatFood = catFoodPerDayInKg * days;
    let totalTurtleFoodInKg = (turtleFoodPerDayInG * days) / 1000;

    let totalFood = totalDogFood + totalCatFood + totalTurtleFoodInKg;

    if(totalFood <= foodInKg){
        let resuide =foodInKg - totalFood;

        console.log(`${Math.floor(resuide)} kilos of food left.`)
    }
    else{
        let needed = totalFood - foodInKg;
        console.log(`${Math.ceil(needed)} more kilos of food are needed.`)
    }
}

solve(["2", "10", "1", "1", "1200"]);