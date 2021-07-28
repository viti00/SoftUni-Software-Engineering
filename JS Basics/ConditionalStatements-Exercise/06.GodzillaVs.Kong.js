function calcolateCost(input){
    let budget = Number(input[0]);
    let staticsCount = Number(input[1]);
    let staticCostumePrice = Number(input[2]);

    let decorationPrice = budget * 0.1;

    let staticsCostumesPrice = staticsCount * staticCostumePrice;

    if (staticsCount > 150){
        staticsCostumesPrice -= staticsCostumesPrice * 0.10;
    }

    let totalCost = decorationPrice + staticsCostumesPrice;

    if (totalCost <= budget){
        console.log("Action!");
        let residue = budget - totalCost;
        console.log(`Wingard starts filming with ${residue.toFixed(2)} leva left.`);
    }
    else{
        console.log("Not enough money!");
        let needed = totalCost - budget;
        console.log(`Wingard needs ${needed.toFixed(2)} leva more.`);
    }
}

calcolateCost(["20000", "120", "55.5"])