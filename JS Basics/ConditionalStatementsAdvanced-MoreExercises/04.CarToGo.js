function carToGo(input){
    let budget = Number(input[0]);
    let season = input[1];

    let classCar = "";
    let cabrioOrJeep = "";
    let cost = 0.0;

    if (budget <= 100){
        classCar = "Economy class";
        if (season == "Summer"){
            cabrioOrJeep = "Cabrio";
            cost = budget * 0.35;
        }
        else if (season == "Winter"){
            cabrioOrJeep = "Jeep";
            cost = budget * 0.65;
        }
    }
    else if (budget > 100 && budget <= 500){
        classCar = "Compact class";
        if (season == "Summer"){
            cabrioOrJeep = "Cabrio";
            cost = budget * 0.45;
        }
        else if (season == "Winter"){
            cabrioOrJeep = "Jeep";
            cost = budget * 0.80;
        }
    }
    else if (budget > 500){
        classCar = "Luxury class";
        cabrioOrJeep = "Jeep";
        cost = budget * 0.90;
    }

    console.log(classCar);
    console.log(`${cabrioOrJeep} - ${cost.toFixed(2)}`);
}

carToGo(["450", "Summer"]);