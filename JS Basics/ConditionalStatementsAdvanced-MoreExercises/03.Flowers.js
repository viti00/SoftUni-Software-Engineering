function flowers(input){
    let chrysanthemumsCount= Number(input[0]);
    let rosesCount = Number(input[1]);
    let tulipsCount = Number(input[2]);

    let season = input[3];
    let isHoliday = input[4];

    let crysanthemumsSpringAndSummerPrice = 2.00;
    let rosesSpringAndSummerPrice = 4.10;
    let tulipsSpringAndSummerPrice = 2.50;

    let crysanthemumsWinterAndAutumnPrice = 3.75;
    let rosesWinterAndAutumnPrice = 4.50;
    let tulipsWinterAndAutumnPrice = 4.15;

    let cost = 0.0;

    if (season == "Summer" || season == "Spring"){
        cost = crysanthemumsSpringAndSummerPrice * chrysanthemumsCount + rosesSpringAndSummerPrice * rosesCount + tulipsSpringAndSummerPrice * tulipsCount;
    }
    else if(season == "Autumn" || season == "Winter"){
        cost = crysanthemumsWinterAndAutumnPrice * chrysanthemumsCount  + rosesWinterAndAutumnPrice * rosesCount + tulipsWinterAndAutumnPrice * tulipsCount;
    }

    if (isHoliday == "Y"){
        cost += cost * 0.15;
    }

    if (season == "Spring" && tulipsCount > 7){
        cost -= cost * 0.05;
    }
    else if (season == "Winter" && rosesCount >= 10){
        cost -= cost * 0.1;
    }
    if (chrysanthemumsCount + tulipsCount + rosesCount > 20){
        cost -= cost * 0.2;
    }

    let totalSum = cost + 2;

    console.log(totalSum.toFixed(2));
}

flowers(["3", "10", "9", "Winter", "N"]);