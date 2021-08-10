function hotelRoom(input){
    let month = input[0];

    let overnightCount = Number(input[1]);

    let studioPrice = 0.0;
    let apartmentPrice = 0.0;
    let studioCost = 0.0;
    let apartmentCost = 0.0;

    if (month == "May" || month == "October"){
        studioPrice = 50;
        apartmentPrice = 65;
        studioCost = overnightCount * studioPrice;
        apartmentCost = overnightCount * apartmentPrice;
        if (overnightCount > 7 && overnightCount <= 14){
            studioCost = studioCost * 0.95;
        }
        else if (overnightCount > 14){
            studioCost = studioCost * 0.70;
            apartmentCost = apartmentCost * 0.90;
        }
        
    }
    else if (month == "June" || month == "September"){
        studioPrice = 75.20;
        apartmentPrice = 68.70;
        studioCost = overnightCount * studioPrice;
        apartmentCost = overnightCount * apartmentPrice;
        if (overnightCount > 14){
            studioCost = studioCost * 0.80;
            apartmentCost = apartmentCost * 0.90;
        }
    }
    else if (month == "July" || month == "August"){
        studioPrice = 76;
        apartmentPrice = 77;
        studioCost = overnightCount * studioPrice;
        apartmentCost = overnightCount * apartmentPrice;
        if (overnightCount > 14){
            apartmentCost = apartmentCost * 0.90;
        }
    }

    console.log(`Apartment: ${apartmentCost.toFixed(2)} lv.`);
    console.log(`Studio: ${studioCost.toFixed(2)} lv.`);
}

hotelRoom(["May", "15"]);