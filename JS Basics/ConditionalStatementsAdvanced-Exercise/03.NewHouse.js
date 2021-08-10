function newHouse(input){
    let flowerType = input[0];
    let flowerCount = Number(input[1]);
    let budget = Number(input[2]);

    let totalPrice = 0.0;

    switch(flowerType){
        case"Roses":
            totalPrice = flowerCount * 5;
        break;
        case"Dahlias":
            totalPrice = flowerCount * 3.80;
        break;
        case"Tulips":
            totalPrice = flowerCount * 2.80;
        break;
        case"Narcissus":
            totalPrice = flowerCount * 3;
        break;
        case"Gladiolus":
            totalPrice = flowerCount * 2.50;
        break;
    }

    if (flowerType == "Roses" && flowerCount > 80){
        totalPrice = totalPrice * 0.90;
    }
    else if (flowerType == "Dahlias" && flowerCount > 90){
        totalPrice = totalPrice * 0.85;
    }
    else if (flowerType == "Tulips" && flowerCount > 80){
        totalPrice = totalPrice * 0.85;
    }
    else if (flowerType == "Narcissus" && flowerCount < 120){
        totalPrice += totalPrice * 0.15;
    }
    else if (flowerType == "Gladiolus" && flowerCount < 80){
        totalPrice += totalPrice * 0.20;
    }

    if (totalPrice > budget){
        let needed = totalPrice - budget;
        console.log(`Not enough money, you need ${needed.toFixed(2)} leva more.`);
    }
    else{
        let left = budget - totalPrice;
        console.log(`Hey, you have a great garden with ${flowerCount} ${flowerType} and ${left.toFixed(2)} leva left.`);
    }
}
newHouse(["Roses", "55", "250"]);