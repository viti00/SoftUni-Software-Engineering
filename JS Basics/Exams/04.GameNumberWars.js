function gameNumbers(input){
    let firstPlayerName = input.shift();
    let secondPlayerName = input.shift();

    let firstPlayerPoints = 0;
    let secondPlayerPoints = 0;

    let command = input.shift();

    while(command != "End of game"){
        let firstPlayerCard = Number(command);
        let secondPlayerCard = Number(input.shift());

        if (firstPlayerCard > secondPlayerCard){
            firstPlayerPoints += firstPlayerCard - secondPlayerCard;
        }
        else if (firstPlayerCard < secondPlayerCard){
            secondPlayerPoints += secondPlayerCard - firstPlayerCard;
        }
        else {
            firstPlayerCard = Number(input.shift());
            secondPlayerCard = Number(input.shift());
            let winner = "";
            let winerPoints = 0;
            if (firstPlayerCard > secondPlayerCard){
                winner = firstPlayerName;
                winerPoints = firstPlayerPoints;
            }
            else if (firstPlayerCard < secondPlayerCard){
                winner = secondPlayerName;
                winerPoints = secondPlayerPoints;
            }
            console.log(`Number wars!`);
            console.log(`${winner} is winner with ${winerPoints} points`);
            break;
        }

        command = input.shift();
    }

    if (command == "End of game"){
        console.log(`${firstPlayerName} has ${firstPlayerPoints} points`);
        console.log(`${secondPlayerName} has ${secondPlayerPoints} points`);
    }
}
gameNumbers(["Desi",
"Niki",
"7",
"5",
"3",
"4",
"3",
"3",
"5",
"3"]);
