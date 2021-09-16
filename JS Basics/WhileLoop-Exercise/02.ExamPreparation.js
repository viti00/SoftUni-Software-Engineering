function examPreparation(input){
    let failsCount = Number(input.shift());
    let command = input.shift();
    let fails = 0;
    let i = 0;
    let allGradesSum = 0.0;
    let problemsCount = 0;
    let problemName ="";

    while(command != "Enough"){
        problemName = command;
        let grade = Number(input[i]);
        problemsCount++;

        if (grade <= 4){
            fails++;
            if (fails === failsCount){
                console.log(`You need a break, ${fails} poor grades.`);
                break;
            }
        }

        allGradesSum += grade;

        i++;
        command = input[i];
        i++;

    }
    let averageScore = allGradesSum / problemsCount;
    if(failsCount > fails){
        console.log(`Average score: ${averageScore.toFixed(2)}`);
        console.log(`Number of problems: ${problemsCount}`);
        console.log(`Last problem: ${problemName}`);
    }
}

examPreparation(["3", "Money", "3", "Story", "2", "SpringTime", "3", "Bus", "6", "Enough"]);