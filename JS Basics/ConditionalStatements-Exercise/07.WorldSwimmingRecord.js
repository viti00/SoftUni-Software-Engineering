function solve(input){
    let worldRecord = Number(input[0]);
    let meters = Number(input[1]);
    let secondsFor1Meter = Number(input[2]);

    let time = meters * secondsFor1Meter;

    let delay = Math.floor((meters / 15)) * 12.5;

    let totalTime = time + delay;

    if (totalTime < worldRecord){
        console.log(`Yes, he succeeded! The new world record is ${totalTime.toFixed(2)} seconds.`);
    }
    else{
        let neededSeconds = totalTime - worldRecord;

        console.log(`No, he failed! He was ${neededSeconds.toFixed(2)} seconds slower.`);
    }
}

solve(["55555.67", "3017", "5.03"]);