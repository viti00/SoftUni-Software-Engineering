function sumSeconds(input){
    let firstRacer = Number(input[0]);
    let secondRacer = Number(input[1]);
    let thirdRacer = Number(input[2]);

    let totalTime = firstRacer + secondRacer + thirdRacer;

    if (totalTime < 60){
        if (totalTime < 10){
            console.log(`0:0${totalTime}`);
        }
        else{
            console.log(`0:${totalTime}`);
        }
    }
    else {
        let minutes = parseInt(totalTime / 60);
        let seconds = totalTime % 60;
        if (seconds < 10){
            console.log(`${minutes}:0${seconds}`);
        }
        else{
            console.log(`${minutes}:${seconds}`);
        }
    }
}

sumSeconds(["10", "12", "14"]);