function countingCost(input){
    let dogsCount = input[0];
    let otherPets = input[1];
    let cost = dogsCount * 2.50 + otherPets * 4;

    console.log (`${cost} lv.`);

}

countingCost([5, 4]);