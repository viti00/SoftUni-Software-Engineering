function combinations(input){
    let number = Number(input.shift());
    let combinationCounter = 0;

    for (let first = 0; first <= number; first++) {
        
        for (let second = 0; second <= number; second++) {
            
            
            for (let third = 0; third <= number; third++) {
                
                let sum = first + second + third;

                if (sum == number){
                    combinationCounter++;
                }
            }
        }
    }

    console.log(combinationCounter);
}

combinations(["25"]);