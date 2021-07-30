function solve(input){
    let fuelType = input[0];
    let litters = Number(input[1]);
    let card = input[2];

    let gasPerLitterPrice = 0.93;
    let gasolinePerLitterPrice = 2.22;
    let dieselPerLitterPrice = 2.33;

    let totalPrice = 0.0;

    if (fuelType == "Gas"){
        if (card == "Yes"){
            gasPerLitterPrice -= 0.08;
        }
        totalPrice = gasPerLitterPrice * litters;
    }
    else  if (fuelType == "Gasoline"){
        if (card == "Yes"){
            gasolinePerLitterPrice -= 0.18;
        }
        totalPrice = gasolinePerLitterPrice * litters;
    }
    else if (fuelType == "Diesel"){
        if (card == "Yes"){
            dieselPerLitterPrice -= 0.12;
        }
        totalPrice = dieselPerLitterPrice * litters;
    }

    if (litters >= 20 && litters <= 25){
        totalPrice = totalPrice * 0.92;
    }
    else if (litters > 25){
        totalPrice = totalPrice * 0.90;
    }

    console.log(`${totalPrice.toFixed(2)} lv.`);
}

solve(["Gas", "30", "Yes"]);