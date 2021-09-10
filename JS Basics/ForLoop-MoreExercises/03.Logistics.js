function logistic(input){
    let n = Number(input.shift());
    let microbusCount = 0;
    let truckCount = 0;
    let trainCount = 0;
    let totalWeight = 0;

   

    for (let index = 0; index < n; index++) {
        let weight = Number(input[index]);
        totalWeight += weight;
        if (weight <= 3){
            microbusCount += weight;
        }
        else if (weight >= 4 && weight <= 11){
            truckCount += weight;
        }
        else if (weight >= 12){
            trainCount += weight;
        }
        
    }

    let average = (microbusCount * 200 + truckCount * 175 + trainCount * 120) / totalWeight;
    let microbusPercent = microbusCount / totalWeight * 100;
    let truckPercent = truckCount / totalWeight * 100;
    let trainPercent = trainCount / totalWeight * 100;


    console.log(average.toFixed(2));
    console.log(`${microbusPercent.toFixed(2)}%`);
    console.log(`${truckPercent.toFixed(2)}%`);
    console.log(`${trainPercent.toFixed(2)}%`);
}

logistic(["4", "1", "5", "16","3"]);