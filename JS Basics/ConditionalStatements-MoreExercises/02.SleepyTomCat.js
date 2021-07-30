function sleepingTime(input){
    let holidays = Number(input[0]);

    let workDays = 365 - holidays;

    let whileWorkPlayTime = workDays * 63;
    
    let holidayPlayTime = holidays * 127;

    let totalTime = whileWorkPlayTime + holidayPlayTime;
    let hours;
    let minutes;
    if (totalTime > 30000){
        let overflowTime = totalTime - 30000;
        hours = Math.floor(overflowTime / 60);
        minutes = overflowTime % 60;
        console.log("Tom will run away");
        console.log(`${hours} hours and ${minutes} minutes more for play`)
    }
    else {
        let lessTime = 30000 - totalTime;

        hours = Math.floor(lessTime / 60);

        minutes = lessTime % 60;

        console.log("Tom sleeps well");
        console.log(`${hours} hours and ${minutes} minutes less for play`)
    }
}

sleepingTime(["20"]);