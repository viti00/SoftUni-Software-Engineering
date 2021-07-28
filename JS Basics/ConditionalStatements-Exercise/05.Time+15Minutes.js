function solve(input){
    let hours = Number(input[0]);
    let minutes = Number(input[1]);

    let after15Minutes = minutes + 15;

    if (after15Minutes >= 60){
        hours++;
        minutes = after15Minutes - 60;
    }
    else{
        minutes = after15Minutes;
    }

    if(hours == 24){
        hours = 0;
    }

    if (minutes < 10){
        console.log(`${hours}:0${minutes}`);
    }
    else {
        console.log(`${hours}:${minutes}`);
    }


}

solve(["11", "08"]);