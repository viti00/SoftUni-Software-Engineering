function parking(input){

    let daysCount = Number(input.shift());
    let hoursPerDay = Number(input.shift());
    let totalSum = 0;

debugger;

    for (let day = 1; day <= daysCount; day++) {
        let currDaySum = 0;
        for (let hour = 1; hour <= hoursPerDay; hour++) {
            if (day % 2 == 0 && hour % 2 == 1){
                currDaySum += 2.50;
            }
            else if (day % 2 == 1 && hour % 2 == 0){
                currDaySum += 1.25;
            }
            else {
                currDaySum += 1;
            }
            
        }

        console.log(`Day: ${day} - ${currDaySum.toFixed(2)} leva`);
        totalSum += currDaySum;
        currDaySum = 0;

        
    }

    console.log(`Total: ${totalSum.toFixed(2)} leva`);
}

parking(["5", "2"]);

