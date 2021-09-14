function graduation(input){
    let name = input.shift();

    let grade = 1;
    let i = 0;
    let failCount = 0;
    let total = 0.0;

    while(grade <= 12){
        let currGrade = Number(input[i]);

        if (currGrade < 4.00){
            failCount++;
        }
        else{
            grade++;
            total += currGrade;
        }

        if(failCount == 2){
            console.log(`${name} has been excluded at ${grade} grade`);
            break;
        }

        i++;
    }

    if(grade == 13){
        let average = total / 12;
        console.log(`${name} graduated. Average grade: ${average.toFixed(2)}`);
    }
}

graduation(["gosho", "5", "6", "5", "6", "5", "6", "6", "2", "3", "5", "6", "5"]);