function skiTrip(input){
    let days = Number(input[0]);
    let roomType = input[1];
    let grade = input[2];
    
    let discountPercent = 0.0;
    let cost = 0.0;

    switch(roomType){
        case"room for one person":
            cost = 18.00 * (days - 1);

        break;
        case"apartment":
            cost = 25.00 * (days - 1);

            if ((days - 1) < 10){
                discountPercent = 30;
            }
            else if (days >= 10 && days <= 15){
                discountPercent = 35;
            }
            else if (days > 15){
                discountPercent = 50;
            }
        break;
        case"president apartment":
            cost = 35.00 * (days - 1);

            if ((days - 1) < 10){
                discountPercent = 10;
            }
            else if (days >= 10 && days <= 15){
                discountPercent = 15;
            }
            else if (days > 15){
                discountPercent = 20;
            }
        break;
    }

    cost -= cost * (discountPercent / 100);

    if (grade == "positive"){
        cost += cost * 0.25;
    }
    else if (grade == "negative"){
        cost -= cost * 0.1;
    }

    console.log(cost.toFixed(2));
}

skiTrip(["14", "apartment", "positive"]);