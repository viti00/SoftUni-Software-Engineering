function grades(input){
    let n = Number(input.shift());

    let weakCount =0;
    let middleCount = 0;
    let goodCount = 0;
    let excellentCount = 0;

    let totalGrades = 0;

    for (let index = 0; index < n; index++) {
        let grade = Number(input[index]);
        totalGrades += grade;

        if (grade >= 2.00 && grade <= 2.99){
            weakCount++;
        }
        else if (grade >= 3.00 && grade <= 3.99){
            middleCount++;
        }
        else if (grade >= 4.00 && grade <= 4.99){
            goodCount++;
        }
        else if (grade >= 5.00){
            excellentCount++;
        }
        
    }
    let average = totalGrades / n;
    let topStudentsPercent = excellentCount / n * 100;
    let goodStudentsPercent = goodCount / n * 100;
    let middleStudentsPecent = middleCount / n * 100;
    let failStudentsPercent = weakCount / n * 100;

    console.log(`Top students: ${topStudentsPercent.toFixed(2)}%`);
    console.log(`Between 4.00 and 4.99: ${goodStudentsPercent.toFixed(2)}%`);
    console.log(`Between 3.00 and 3.99: ${middleStudentsPecent.toFixed(2)}%`);
    console.log(`Fail: ${failStudentsPercent.toFixed(2)}%`);
    console.log(`Average: ${average.toFixed(2)}`);
}

grades(["6", "2", "3", "4", "5","6", "2.2"]);