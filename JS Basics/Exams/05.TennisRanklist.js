function tennisRanklist(input){
    let n = Number(input.shift());

    let winCount = 0;
    let startPoints = Number(input.shift());
    let totalPoints = startPoints;


    for (let i = 1; i <= n; i++) {
        let type = input.shift();

        if (type == "W"){
            totalPoints += 2000;
            winCount++;
        }
        else if (type == "F"){
            totalPoints += 1200;
        }
        else if (type == "SF"){
            totalPoints += 720;
        }
        
    }
    let averagePoints = (totalPoints - startPoints) / n;
    let winPercent = (winCount / n) * 100;
    console.log(`Final points: ${totalPoints}`);
    console.log(`Average points: ${parseInt(averagePoints)}`);
    console.log(`${winPercent.toFixed(2)}%`);
}

tennisRanklist(["5",
"1400",
"F",
"SF",
"W",
"W",
"SF"]);


