function addBags(input){
    let over20KgBagPrice = Number(input.shift());
    let bagWeight = Number(input.shift());
    let daysLeft = Number(input.shift());
    let bagsCount = Number(input.shift());
    let bagPrice = 0;

    if (bagWeight < 10){
        bagPrice = 0.2 * over20KgBagPrice;
    }
    else if (bagWeight >= 10 && bagWeight <= 20){
        bagPrice = 0.5 * over20KgBagPrice;
    }
    else if (bagWeight > 20){
        bagPrice = over20KgBagPrice;
    }

    if (daysLeft > 30){
        bagPrice += bagPrice * 0.1;
    }
    else if (daysLeft >= 7 && daysLeft <= 30){
        bagPrice += bagPrice * 0.15;
    }
    else if (daysLeft < 7){
        bagPrice += bagPrice * 0.40;
    }

    let finalPrice = bagsCount * bagPrice;

    console.log(`The total price of bags is: ${finalPrice.toFixed(2)} lv.`);
}

addBags(["63.80",
"23",
"3",
"1"])
