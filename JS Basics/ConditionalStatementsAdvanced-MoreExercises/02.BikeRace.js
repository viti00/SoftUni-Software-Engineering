function bikeRace(input){
    let juniorsCount = Number(input[0]);
    let seniorsCount = Number(input[1]);
    let traseType = input[2];

    let taks = 1;
    let totalJuniorTakses = 0.0;
    let totalSeniorTakses = 0.0;

    if (juniorsCount + seniorsCount >= 50 && traseType == "cross-country"){
        taks = 1 * 0.75;
    }

    switch(traseType){
        case"trail":
            totalJuniorTakses = juniorsCount * (taks * 5.50);
            totalSeniorTakses = seniorsCount * (taks * 7);
        break;
        case"cross-country":
            totalJuniorTakses = juniorsCount * (taks * 8);
            totalSeniorTakses = seniorsCount * (taks * 9.50);
        break;
        case"downhill":
            totalJuniorTakses = juniorsCount * (taks * 12.25);
            totalSeniorTakses = seniorsCount * (taks * 13.75);
        break;
        case"road":
            totalJuniorTakses = juniorsCount * (taks * 20);
            totalSeniorTakses = seniorsCount * (taks * 21.50);
        break;
    }

    let totalSum = (totalJuniorTakses + totalSeniorTakses) * 0.95;

    console.log(totalSum.toFixed(2));
}

bikeRace(["30", "25", "cross-country"]);