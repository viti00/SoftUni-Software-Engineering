function transport(input){
    let kilometers = Number(input[0]);

    let dayOrNight = input[1];

    let totalCost = 0.0;

    if (kilometers < 20 && dayOrNight == "day"){
        
        totalCost = 0.70 + (kilometers * 0.79);
    }
    else if (kilometers < 20 && dayOrNight == "night"){
        totalCost = 0.70 + (kilometers * 0.90);
    }
    else if (kilometers >= 20 && kilometers < 100){
        totalCost = kilometers * 0.09;
    }
    else{
        totalCost = kilometers * 0.06;
    }
    console.log(totalCost.toFixed(2));
}

transport(["5", "day"]);