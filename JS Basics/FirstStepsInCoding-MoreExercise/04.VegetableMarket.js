function calculateSum(input){
    let vegetablesPrice= Number(input[0]);
    let fruitsPrice = Number(input[1]);
    let vegetablesHeight = Number(input[2]);
    let fruitsHeight = Number(input[3]);

    let finalPrice = vegetablesHeight * vegetablesPrice + fruitsPrice * fruitsHeight;
    let finalPriceInEuro = finalPrice / 1.94;
    console.log(finalPriceInEuro.toFixed(2));
}

calculateSum(["0.194", "19.4", "10", "10"]);