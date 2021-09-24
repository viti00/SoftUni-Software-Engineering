function tournament(input){
    debugger;
    let days = Number(input.shift());
    let totalMoney = 0;
    let winGames = 0;
    let loseGames = 0;

    for (let day = 1; day <= days; day++) {
        
        let currDayWinGames = 0;
        let currDayLoseGames = 0;
        let moneyForTheDay = 0;
        let command = input.shift();
        while(command != "Finish"){
            let winOrLose = input.shift();

            if (winOrLose == "win"){
                moneyForTheDay += 20;
                currDayWinGames++;
            }
            else if (winOrLose == "lose"){
                currDayLoseGames++;
            }

            command = input.shift();
        }

        if (currDayWinGames > currDayLoseGames){
            moneyForTheDay += moneyForTheDay * 0.1; 
        }

        winGames += currDayWinGames;
        loseGames += currDayLoseGames;
        totalMoney += moneyForTheDay;
    }

    if (winGames > loseGames){
        totalMoney += totalMoney * 0.2;
        console.log(`You won the tournament! Total raised money: ${totalMoney.toFixed(2)}`);
    }
    else if (winGames < loseGames){
        console.log(`You lost the tournament! Total raised money: ${totalMoney.toFixed(2)}`);
    }
}

tournament(["2", "voleyball", "win", "football", "lose", "basket", "win", "Finish", "golf", "win", "tennis", "win", "badminton", "win", "Finish"]);