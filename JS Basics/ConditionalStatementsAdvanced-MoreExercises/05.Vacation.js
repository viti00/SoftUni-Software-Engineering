function vacantion(input){
    let budget = Number(input[0]);
    let season = input[1];

    let roomType = "";
    let location = "";
    let cost = 0.0;

    if (budget <= 1000){
        roomType = "Camp";
        if (season == "Winter"){
            location = "Morocco"
            cost = budget * 0.45;
        }
        else if (season == "Summer"){
            location = "Alaska";
            cost = budget * 0.65;
        }
    } 
    else if (budget > 1000 && budget <= 3000){
        roomType = "Hut"
        if (season == "Winter"){
            location = "Morocco"
            cost = budget * 0.60;
        }
        else if (season == "Summer"){
            location = "Alaska";
            cost = budget * 0.80;
        }
    }
    else if(budget > 3000){
        roomType = "Hotel"
        if (season == "Winter"){
            location = "Morocco"
        }
        else if (season == "Summer"){
            location = "Alaska";
        }
        cost = budget * 0.90;
    }

    console.log(`${location} - ${roomType} - ${cost.toFixed(2)}`);
}

vacantion(["800", "Summer"])