function footballResults(input){

    let winCount = 0;
    let loseCount = 0;
    let drawCount = 0;
    for (let i = 1; i <= 3; i++) {
        let results = input.shift();

        if (results[0] > results[2]){
            winCount++;
        }
        else if (results [0] == results [2]){
            drawCount++;
        }
        else if (results [0] < results[2]){
            loseCount++;
        }
        
    }

    console.log(`Team won ${winCount} games.`);
    console.log(`Team lost ${loseCount} games.`);
    console.log(`Drawn games: ${drawCount}`)
}

footballResults(["4:2",
"0:3",
"1:0"]);
