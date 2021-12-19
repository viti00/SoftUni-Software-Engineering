function uniquePin(input){
    let firstNumEndIndex = Number(input.shift());
    let secondNumEndIndex = Number(input.shift());
    let thirdNumEndIndex = Number(input.shift());
    

    for (let first = 1; first <= firstNumEndIndex; first++) {
        
        for (let second = 1; second <= secondNumEndIndex; second++) {
            
            for (let third = 1; third <= thirdNumEndIndex; third++) {
                
                if(first % 2 == 0 && third % 2 == 0 && second >= 1 && second <= 7){
                    if (second == 2 || second == 3 || second == 5 || second == 7){
                        console.log(`${first} ${second} ${third}`);
                    }
                }
            }
        }
    }

}

uniquePin(["3", "5", "5"]);