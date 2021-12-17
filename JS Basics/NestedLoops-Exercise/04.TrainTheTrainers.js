function trainTheTrainers(input){
    let judgesCount = Number(input.shift());

    let command = input.shift();
    let finalGrade = 0;
    let presentationCount = 0;

    while(command != "Finish"){
        let presentationName = command;
        presentationCount++;
        let currGrade = 0;
        for (let index = 1; index <= judgesCount; index++) {
            let grade = Number(input.shift());
            currGrade += grade;
        }
        let currAverage = currGrade / judgesCount;
        console.log(`${presentationName} - ${currAverage.toFixed(2)}.`);
        finalGrade += currAverage;

        command = input.shift();
    }
    let finalAverage = finalGrade / presentationCount;
    console.log(`Student's final assessment is ${finalAverage.toFixed(2)}.`);
}

trainTheTrainers(["2", "while", "6.00", "5.50", "for", "5.84", "5.66", "Finish"]);