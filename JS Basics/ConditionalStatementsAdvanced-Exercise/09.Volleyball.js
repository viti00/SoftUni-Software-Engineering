function volleyball(input){
    let yearType = input[0];
    let holidays = Number(input[1]);
    let weekendInHome = Number(input[2]);

    let inSofia = 48 - weekendInHome;

    let playsInSofia = inSofia * (3 / 4);

    let playsInSofiaHolidays = holidays * (2/3);

    let totalGames = playsInSofia + playsInSofiaHolidays + weekendInHome;

    if(yearType == "leap"){
        totalGames += totalGames * 0.15;
    }   

    console.log(Math.floor(totalGames));
}

volleyball(["leap", "5", "2"]);