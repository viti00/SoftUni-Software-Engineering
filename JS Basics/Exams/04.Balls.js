function balls(input){
    let n = Number(input.shift());
    let points = 0;

    let redCount = 0;
    let orangeCount = 0;
    let yellowCount = 0;
    let whiteCount = 0;
    let otherCount = 0;
    let blackCont = 0;

    for (let i = 1; i <= n; i++) {
        
        let ballColor = input.shift();

        switch(ballColor){
            case"red":
                redCount++;
                points += 5;
            break;
            case"orange":
                orangeCount ++;
                points += 10;
            break;
            case"yellow":
                yellowCount++;
                points += 15;
            break;
            case"white":
                whiteCount++;
                points+= 20;
            break;
            case"black":
                blackCont ++;
                points /= 2;
            break;
            default:
                otherCount++;
                break;
        }
        
    }

    console.log(`Total points: ${parseInt(points)}`);
    console.log(`Points from red balls: ${redCount}`);
    console.log(`Points from orange balls: ${orangeCount}`);
    console.log(`Points from yellow balls: ${yellowCount}`);
    console.log(`Points from white balls: ${whiteCount}`);
    console.log(`Other colors picked: ${otherCount}`);
    console.log(`Divides from black balls: ${blackCont}`);
}

balls(["3",
"white",
"black",
"pink"]);
