function onTime(input){
    let examHour = Number(input[0]);
    let examMinutes = Number(input[1]);

    let commingHour = Number(input[2]);
    let commingMinutes = Number(input[3]);

    let commingType = "";

    let examHourToMinutes = examHour * 60 + examMinutes;
    let commingHourToMinutes = commingHour * 60 + commingMinutes;

    let minutes = examHourToMinutes - commingHourToMinutes;

    if(minutes < 0){
        commingType = "Late";
    }
    else if (minutes >= 0 && minutes <= 30){
        commingType = "On time";
    }
    else{
        commingType = "Early";
    }

    console.log(commingType);
    let h = 0.0;
    let m = 0.0;

    if (minutes > 0 && minutes < 60){
        console.log(`${minutes} minutes before the start`)
    }
    else if (minutes >= 60){
        h = parseInt(minutes / 60);
        m = minutes % 60;

        if (m < 10){
            console.log(`${h}:0${m} hours before the start`);
        }
        else{
            console.log(`${h}:${m} hours before the start`);
        }
    }
    else if (minutes < 0 && minutes > -60){
        console.log(`${Math.abs(minutes)} minutes after the start`);
    }
    else if (minutes <= - 60){
        h = Math.abs(parseInt(minutes / 60));
        m = Math.abs(minutes % 60);
        if (m < 10){
            console.log(`${h}:0${m} hours after the start`);
        }
        else{
            console.log(`${h}:${m} hours after the start`);
        }
    }

}

onTime(["14", "00", "13", "55"]);