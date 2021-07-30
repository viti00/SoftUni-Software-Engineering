function solve(input){
    let neededHours = Number(input[0]);
    let days = Number(input[1]);
    let overTimeWorkers = Number(input[2]);

    let workHours = days * 0.9 * 8;

    let overTimeHours = overTimeWorkers * 2 * days;

    let totalWorkTime =Math.floor(workHours + overTimeHours);

    if (totalWorkTime >= neededHours){
        let resuide = totalWorkTime - neededHours;

        console.log(`Yes!${resuide} hours left.`);
    }
    else {
        let neededMore = neededHours - totalWorkTime;
        console.log(`Not enough time!${neededMore} hours needed.`);
    }
}

solve(["90", "7", "3"]);