function calculateCost(input){
    let strawberryPrice = Number(input[0]);
    let bananas = Number(input[1]);
    let oranges = Number(input[2]);
    let raspberries = Number(input[3]);
    let strawberries = Number(input[4]);

    let raspberryPrice = strawberryPrice / 2;
    let bananaPrice = raspberryPrice - raspberryPrice * 0.8;
    let orangePrice = raspberryPrice - raspberryPrice * 0.4;

    let cost = raspberryPrice * raspberries + strawberryPrice * strawberries + bananas * bananaPrice + oranges * orangePrice;

    console.log(cost.toFixed(2));
}

calculateCost(["48", "10","3.3", "6.5", "1.7"]);