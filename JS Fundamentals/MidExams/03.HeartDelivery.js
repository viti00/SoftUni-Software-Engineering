function heartDelivery(arr){
    let neighborhood = arr.shift().split("@");
    debugger;

    let command = arr.shift();
    let currPosition = 0;
    while(command != "Love!"){
        let length = Number(command[command.length - 1]);
        currPosition += length;
        if (currPosition >= neighborhood.length){
            currPosition = 0;
        }
        if (neighborhood[currPosition] > 0){
            neighborhood[currPosition] -= 2;
            if (neighborhood[currPosition] == 0){
                console.log(`Place ${currPosition} has Valentine's day.`);
            }
        }
        else if (neighborhood[currPosition] == 0){
            console.log(`Place ${currPosition} already had Valentine's day.`);
        }

        command = arr.shift();
    }
    console.log(`Cupid's last position was ${currPosition}.`)
    let failedCount = 0;
    for (let i = 0; i < neighborhood.length; i++)
            {
                if (neighborhood[i] > 0)
                {
                    failedCount++;
                }
            }

            if (failedCount > 0)
            {
                console.log(`Cupid has failed ${failedCount} places.`)
            }
            else
            {
                console.log("Mission was successful.");
            }
            
}

heartDelivery(["2@4@2",
"Jump 2",
"Jump 2",
"Jump 8",
"Jump 3",
"Jump 1",
"Love!"]);