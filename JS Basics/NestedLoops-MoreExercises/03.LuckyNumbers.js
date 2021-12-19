function luckyNumbers(input){
    debugger;
    let n = Number(input.shift());

    let result = "";

    for (let first = 1; first <= 9; first++) {
        
       for (let second = 1; second <= 9; second++) {
           for (let third = 1; third <= 9; third++) {
               
                for (let fourth = 1; fourth <= 9; fourth++) {
                    let firstTwoNumbers = first + second;
                    let secondTwoNumbers = third + fourth;

                    if (firstTwoNumbers == secondTwoNumbers){
                        if (n % firstTwoNumbers == 0 && n % secondTwoNumbers == 0){
                            result += `${first}${second}${third}${fourth}` + " ";
                        }
                    }
                }
               
           }
           
       }
    }
    console.log(result);

}
luckyNumbers(["3"]);