function jump(input){
    let high = Number(input.shift());
    debugger;
    let currHigh = high - 30;
    let jumpsCount = 0;
    

    while(high >= currHigh){
        let unsuccsesCount = 0;

        for (let i = 1; i <= 3; i++) {
            let jump = Number(input.shift());
            jumpsCount++;
            if (jump > currHigh){
                currHigh += 5;
                break;
            }
            else{
                unsuccsesCount++;
            }
            
        }
        if (unsuccsesCount == 3){
            break;
        }
        
    }

    if (currHigh > high){
        console.log(`Tihomir succeeded, he jumped over ${high}cm after ${jumpsCount} jumps.`);
    }
    else {
        console.log(`Tihomir failed at ${currHigh}cm after ${jumpsCount} jumps.`);
    }
}

jump(["231",
"205",
"212",
"213",
"228",
"229",
"230",
"235"]);
