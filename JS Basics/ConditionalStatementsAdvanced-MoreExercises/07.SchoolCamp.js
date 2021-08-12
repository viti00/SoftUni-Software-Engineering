function schoolCamp(input){
    let season = input[0];
    let groupType = input[1];

    let studentsCount = Number(input[2]);
    let overnightCount = Number(input[3]);

    let sport = "";
    let cost = 0.0;

    if (groupType == "boys"){
        if (season == "Summer"){
            sport = "Football";
            cost = studentsCount * overnightCount * 15;
        }
        else if (season == "Spring"){
            sport = "Tennis";
            cost = studentsCount * overnightCount * 7.20;
        }
        else if (season == "Winter"){
            sport = "Judo";
            cost = studentsCount * overnightCount * 9.60;
        }
    }
    else if (groupType == "girls"){
        if (season == "Summer"){
            sport = "Volleyball";
            cost = studentsCount * overnightCount * 15;
        }
        else if (season == "Spring"){
            sport = "Athletics";
            cost = studentsCount * overnightCount * 7.20;
        }
        else if (season == "Winter"){
            sport = "Gymnastics";
            cost = studentsCount * overnightCount * 9.60;
        }
    }
    else if(groupType == "mixed"){
        if (season == "Summer"){
            sport = "Swimming";
            cost = studentsCount * overnightCount * 20;
        }
        else if (season == "Spring"){
            sport = "Cycling";
            cost = studentsCount * overnightCount * 9.50;
        }
        else if (season == "Winter"){
            sport = "Ski";
            cost = studentsCount * overnightCount * 10;

        }
    }

    if (studentsCount >= 10 && studentsCount < 20){
        cost = cost * 0.95;
    }
    else if (studentsCount >= 20 && studentsCount < 50){
        cost = cost * 0.85;
    }
    else if (studentsCount >= 50){
        cost = cost * 0.50;
    }

    console.log(`${sport} ${cost.toFixed(2)} lv.`);
}

schoolCamp(["Spring", "girls", "20", "7"]);