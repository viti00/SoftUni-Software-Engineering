function histogram(input){
    let numbersCount = Number(input[0]);

    let p1 = 0.0;
    let p2 = 0.0;
    let p3 = 0.0;
    let p4 = 0.0;
    let p5 = 0.0;

    for (let index = 1; index <= numbersCount; index++) {
        let num = input[index];

        if (num < 200){
            p1++;
        }
        else if (num >= 200 && num<= 399){
            p2++;
        }
        else if (num >= 400 && num <= 599){
            p3++;
        }
        else if (num >= 600 && num <= 799){
            p4++;
        }
        else if (num >= 800){
            p5++;
        }
        
    }

    let p1Percent = p1 / numbersCount * 100;
    let p2Percent = p2 / numbersCount * 100;
    let p3Percent = p3 / numbersCount * 100;
    let p4Percent = p4 / numbersCount * 100;
    let p5Percent = p5 / numbersCount * 100;

    console.log(`${p1Percent.toFixed(2)}%`);
    console.log(`${p2Percent.toFixed(2)}%`);
    console.log(`${p3Percent.toFixed(2)}%`);
    console.log(`${p4Percent.toFixed(2)}%`);
    console.log(`${p5Percent.toFixed(2)}%`);
}

histogram(["3", "1", "2", "999"]);