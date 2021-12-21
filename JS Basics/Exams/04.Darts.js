function darts(input){
    debugger;
    let name = input.shift();
    let command = input.shift();
    let succsesCount = 0;
    let unsuccsesCount = 0;
    let point  = 301;

    while(command != "Retire" && point > 0){
        let field = command;
        let points = Number(input.shift());

        let currPoint = 0;

        if (field == "Single"){
            currPoint = 1 * points;
        }
        else if (field == "Double"){
            currPoint = 2 * points;
        }
        else if (field == "Triple"){
            currPoint = 3 * points;
        }

        if (point >= currPoint){
            point -= currPoint;
            succsesCount++;
        }
        else {
            unsuccsesCount++;
        }
        command = input.shift();
    }

    if (point <= 0){
        console.log(`${name} won the leg with ${succsesCount} shots.`);
    }
    else {
        console.log(`${name} retired after ${unsuccsesCount} unsuccessful shots.`);
    }
}

darts(["Michael van Gerwen",
"Triple",
"20",
"Triple",
"19",
"Double",
"10",
"Single",
"3",
"Single",
"1",
"Triple",
"20",
"Triple",
"20",
"Double",
"20"]);
