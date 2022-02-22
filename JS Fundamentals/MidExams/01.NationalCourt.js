function nationalCourt(input){
    debugger;
    let firstEmployee = Number(input.shift());
    let secondEmployee = Number(input.shift());
    let thirdEmployee = Number(input.shift());

    let peopleCount = Number(input.shift());
    let hours = 0;
    let leftTimeToBreak = 3;
    let totalPeoplePerHour = firstEmployee + secondEmployee + thirdEmployee;

    while(peopleCount > 0){
        if(leftTimeToBreak == 0){
            hours++;
            leftTimeToBreak = 3;
        }
        peopleCount -= totalPeoplePerHour;
        hours++;
        leftTimeToBreak--;
    }

    console.log(`Time needed: ${hours}h.`)

}

nationalCourt((["1",
"2",
"3",
"45"]));