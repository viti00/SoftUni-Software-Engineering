function calculateCost(input){
    let rent = Number(input);
    let cakePrice = rent * 0.2;
    let drinksPrice = cakePrice - cakePrice * 0.45;
    let animatorPrice =  rent / 3;

    let finalPrice = rent  +cakePrice + drinksPrice + animatorPrice;

    console.log(finalPrice);
}

calculateCost("2250");