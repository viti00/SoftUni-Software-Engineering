function bestPlayer(input){
    let command = input.shift();
    let maxGoals = 0;
    let bestPlayerName = "";

    while(command != "END"){
        let playerName = command;

        let goals = Number(input.shift());

        if (goals >= 10){
            bestPlayerName = playerName;
            maxGoals = goals;
            break;
        }

        if (goals > maxGoals){
            maxGoals = goals;
            bestPlayerName = playerName;
        }

        command = input.shift();
    }

    console.log(`${bestPlayerName} is the best player!`);
    if (maxGoals >= 3){
        console.log(`He has scored ${maxGoals} goals and made a hat-trick !!!`);
    }
    else {
        console.log(`He has scored ${maxGoals} goals.`);
    }
}

bestPlayer(["Neymar", "2",
"Ronaldo",
"1",
"Messi",
"3",
"END"]);
