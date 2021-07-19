function countingCost(input){
    let squareMeters = input;
    let cost = squareMeters * 7.61;
    let discount = cost * 0.18;
    let finalPrice = cost - discount;

    console.log(`The final price is: ${finalPrice} lv.`)
    console.log(`The discount is: ${discount} lv.`)
}

countingCost(550);