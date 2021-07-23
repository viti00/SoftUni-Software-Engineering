function calculateCost(input){
    let mackerelPrice = Number(input[0]);
    let spratPrice = Number(input[1]);
    let palamudHeight = Number(input[2]);
    let safridHeight = Number(input[3]);
    let shellHeight = Number(input[4]);

    let shellPrice = 7.50;

    let palamudPrice = mackerelPrice + mackerelPrice * 0.6;
    let safridPrice = spratPrice + spratPrice * 0.8;

    let finalPrice = palamudPrice * palamudHeight + safridHeight * safridPrice + shellPrice * shellHeight;

    console.log(finalPrice.toFixed(2));
}

calculateCost(["6.90", "4.20", "1.5", "2.5", "1"]);