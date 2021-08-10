function journey(input){
    let budget = Number(input[0]);
    let season = input[1];

    let campOrHotel = "";
    let country = "";
    let cost = 0.0;

    if (budget <= 100){
        country = "Bulgaria";
        if (season == "summer"){
            campOrHotel = "Camp";
            cost = budget * 0.30;
        }
        else if (season == "winter"){
            campOrHotel = "Hotel";
            cost = budget * 0.70;
        }
    }
    else if (budget > 100 && budget <= 1000){
        country = "Balkans";
        if (season == "summer"){
            campOrHotel = "Camp";
            cost = budget * 0.40;
        }
        else if (season == "winter"){
            campOrHotel = "Hotel";
            cost = budget * 0.80;
        }
    }
    else if (budget > 1000){
        country = "Europe";
        campOrHotel = "Hotel";
        cost = budget * 0.90;
    }


    console.log(`Somewhere in ${country}`);
    console.log(`${campOrHotel} - ${cost.toFixed(2)}`);
}

journey(["50", "summer"]);