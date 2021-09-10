function gameOfIntervals(input){
    let n = Number(input.shift());

    let interval1Count = 0;
    let interval2Count = 0;
    let interval3Count = 0;
    let interval4Count = 0;
    let interval5Count = 0;
    let invalidIntervalCount = 0;

    let result = 0.0;

    for (let index = 0; index < n; index++) {
        let number = Number(input[index]);
        if(number < 0 || number > 50 ){
            invalidIntervalCount++;
            result /= 2;
        }
        else if (number >= 0 && number <= 9){
            interval1Count++;
            result += number * 0.2;
        }
        else if (number >= 10 && number <= 19){
            interval2Count++;
            result += number * 0.3;
        }
        else if (number >= 20 && number <= 29){
            interval3Count++;
            result += number * 0.4;
        }
        else if (number >= 30 && number <= 39){
            interval4Count++;
            result += 50;
        }
        else if (number >= 40 && number <= 50){
            interval5Count++;
            result += 100;
        }
    }

    let interval1Pecent = interval1Count / n * 100;
    let interval2Pecent = interval2Count / n * 100;
    let interval3Pecent = interval3Count / n * 100;
    let interval4Pecent = interval4Count / n * 100;
    let interval5Pecent = interval5Count / n * 100;
    let invalidPercent = invalidIntervalCount / n * 100;

    console.log(result.toFixed(2));
    console.log(`From 0 to 9: ${interval1Pecent.toFixed(2)}%`);
    console.log(`From 10 to 19: ${interval2Pecent.toFixed(2)}%`);
    console.log(`From 20 to 29: ${interval3Pecent.toFixed(2)}%`);
    console.log(`From 30 to 39: ${interval4Pecent.toFixed(2)}%`);
    console.log(`From 40 to 50: ${interval5Pecent.toFixed(2)}%`);
    console.log(`Invalid numbers: ${invalidPercent.toFixed(2)}%`);
}

gameOfIntervals(["10", "43", "57", "-12", "23", "12", "0", "50", "40", "30", "20"]);