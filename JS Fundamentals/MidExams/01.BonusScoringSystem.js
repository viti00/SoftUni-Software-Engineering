function bonusScoringSystem (input){
    let studentsCount = Number(input.shift());
    let lecturesCount = Number(input.shift());
    let aditionalBonus = Number(input.shift());

    let max = 0;
    let maxAttendances = 0;

    for (let i = 1; i <= studentsCount; i++) {
        let attendances = Number(input.shift());

        let total = attendances / lecturesCount * (5 + aditionalBonus);
        if (total > max){
            max = total;
            maxAttendances = attendances;
        }
    }

    console.log(`Max Bonus: ${Math.ceil(max)}.`);
    console.log(`The student has attended ${maxAttendances} lectures.`)
}

bonusScoringSystem([5, 25, 30, 12, 19, 24 , 16, 20]);