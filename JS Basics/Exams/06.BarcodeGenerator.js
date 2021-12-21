function barcodeGenerator(input){
    let firstNum =input.shift();

    let secondNum = input.shift();

    let result = "";

    let firstNumFirst = firstNum[0];
    let firstNumSecond = firstNum[1];
    let firstNumThird = firstNum[2];
    let firstNumFourth = firstNum[3];


    let secondNumFirst = secondNum[0];
    let secondNumSecond = secondNum[1];
    let secondNumThird = secondNum[2];
    let secondNumFourth = secondNum[3];

    for (let first = firstNumFirst; first <= secondNumFirst; first++) {
        for (let second = firstNumSecond; second <= secondNumSecond; second++) {
            for (let third = firstNumThird; third <= secondNumThird; third++) {
                for (let fourth = firstNumFourth; fourth <= secondNumFourth; fourth++) {
                    if (first % 2 == 1 && second % 2 == 1 && third % 2 == 1 && fourth % 2 == 1){
                        result += `${first}${second}${third}${fourth} `;
                    }
                }
            }
        }
    }
   console.log(result);
}
barcodeGenerator(["3256",
"6579"]);
