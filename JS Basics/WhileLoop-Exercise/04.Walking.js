function walking(input){
    debugger;
    let steps = 0;
    let more = 0.0;
    while(true){
        let command = input.shift();

        if (command == "Going home"){
            let stepstToHome = Number(input.shift());
            steps += stepstToHome;
            if (steps >= 10000){
                more = steps - 10000;
                console.log(`Goal reached! Good job! ${more} steps over the goal!`);
                break;
            }
            else {
                let need = 10000 - steps;
                console.log(`${need} more steps to reach goal.`);
            }
        }
        else{
            steps += Number(command);
            if (steps >= 10000){
                more = steps - 10000;
                console.log(`Goal reached! Good job!`);
                console.log(`${more} steps over the goal!`)
                break;
            }
        }
    }
}

walking(["1000", "1500", "2000", "6500"]);