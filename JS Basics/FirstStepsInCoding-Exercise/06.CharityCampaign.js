function calculateSum(input){
    let cakePrice = 45;
    let wafflesPrice = 5.80;
    let pancakePrice = 3.20;

    let days = Number(input[0]);
    let chefs = Number(input[1]);
    let cakes = Number(input[2]);
    let waffles = Number(input[3]);
    let pancakes = Number(input[4]);

    let productionPerChef = cakes * cakePrice + waffles * wafflesPrice + pancakes * pancakePrice;
    let productionPerDay = productionPerChef * chefs;
    let sum = productionPerDay * days;

    let finalPrice = sum - (sum / 8);

    console.log(finalPrice);
}

calculateSum(["23", "8", "14", "30", "16"]);