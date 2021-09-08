function divideWithoutReminder(input){
    let numbersCount = Number(input[0]);

    let p1Count = 0;
    let p2Count = 0;
    let p3Count= 0;

    for (let index = 1; index <= numbersCount; index++) {
        let num = input[index];
        if(num % 2 == 0){
            p1Count ++;
        }
        if (num % 3 == 0){
            p2Count++;
        }
        if (num % 4 == 0){
            p3Count++;
        }
        
    }

    let p1Percent = p1Count / numbersCount * 100;
    let p2Percent = p2Count / numbersCount * 100;
    let p3Percent = p3Count / numbersCount * 100;

    console.log(`${p1Percent.toFixed(2)}%`);
    console.log(`${p2Percent.toFixed(2)}%`);
    console.log(`${p3Percent.toFixed(2)}%`);
}

divideWithoutReminder(["3", "3", "6","9"]);