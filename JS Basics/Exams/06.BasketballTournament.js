function basketballTournament(input){
    let command = input.shift();
    let winCount = 0;
    let lostCount = 0;
    let gameCount = 0;

    while(command != "End of tournaments"){
        let tournamentName = command;

        let n = Number(input.shift());

        for (let i = 1; i <= n; i++) {
            gameCount++;
            let desiTeamPoints = Number(input.shift());
            let otherTeamPoints = Number(input.shift());

            if (desiTeamPoints > otherTeamPoints){
                console.log(`Game ${i} of tournament ${tournamentName}: win with ${desiTeamPoints - otherTeamPoints} points.`);
                winCount++;
            }
            else if (desiTeamPoints < otherTeamPoints){
                console.log(`Game ${i} of tournament ${tournamentName}: lost with ${otherTeamPoints - desiTeamPoints} points.`);
                lostCount++;
            }
        }

        command = input.shift();
    }

    let winPercent = winCount / gameCount * 100;
    let lostPercent = lostCount / gameCount * 100;
    console.log(`${winPercent.toFixed(2)}% matches win`);
    console.log(`${lostPercent.toFixed(2)}% matches lost`);
}

basketballTournament(["Dunkers",
"2",
"75",
"65",
"56",
"73",
"Fire Girls",
"3",
"67",
"34",
"83",
"98",
"66",
"45",
"End of tournaments"]);
