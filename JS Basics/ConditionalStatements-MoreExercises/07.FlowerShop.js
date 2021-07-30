function solve(input){
    let magnoliaCount = Number(input[0]);
    let hyacinthsCount = Number(input[1]);
    let rosesCount = Number(input[2]);
    let cactusCount = Number(input[3])
    let giftPrice = Number(input[4]);

    let sum = magnoliaCount * 3.25 + hyacinthsCount * 4 + rosesCount * 3.50 + cactusCount * 8;

    let totalSum = 0.95 * sum;

    if (totalSum >= giftPrice){
        let resuide = totalSum - giftPrice;

        console.log(`She is left with ${Math.floor(resuide)} leva.`);
    }
    else{
        let needed = giftPrice - totalSum;
        console.log(`She will have to borrow ${Math.ceil(needed)} leva.`);
    }
}

solve(["2", "3", "5", "1", "50"])
