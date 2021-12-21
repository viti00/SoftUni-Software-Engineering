function fitnesCenter(input){
    let n = Number(input.shift());

    let chestCount = 0;
    let backCount = 0;
    let legsCount = 0;
    let absCount = 0;
    let proteinShakeCount = 0;
    let proteinBarCount = 0;
    
    for (let i = 1; i <= n; i++) {
        let trainingType = input.shift();
        switch(trainingType){
            case"Back":
                backCount++;
            break;
            case"Chest":
                chestCount++;
            break;
            case"Legs":
                legsCount++;
            break;
            case"Abs":
                absCount++;
            break;
            case"Protein shake":
                proteinShakeCount++;
            break;
            case"Protein bar":
                proteinBarCount++;
            break;
        }
    }

    let workoutPercent = ((backCount + chestCount + legsCount + absCount) / n) * 100;
    let proteinPercent = ((proteinBarCount + proteinShakeCount) / n) * 100;

    

    console.log(`${backCount} - back`);
    console.log(`${chestCount} - chest`);
    console.log(`${legsCount} - legs`);
    console.log(`${absCount} - abs`);
    console.log(`${proteinShakeCount} - protein shake`);
    console.log(`${proteinBarCount} - protein bar`);
    console.log(`${workoutPercent.toFixed(2)}% - work out`);
    console.log(`${proteinPercent.toFixed(2)}% - protein`);
}

fitnesCenter(["10",
"Back",
"Chest",
"Legs",
"Abs",
"Protein shake",
"Protein bar",
"Protein shake",
"Protein bar",
"Legs",
"Abs"]);
