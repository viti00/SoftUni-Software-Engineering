function primePairs(input){
    let firstNumStartIndex = Number(input.shift());
    let secondNumStartIndex = Number(input.shift());
    let firstNumDiff = Number(input.shift());
    let secondDiff = Number(input.shift());
    let IsprimeFirst = true;
    let IsPrimeSecond = true;

    for (let firstPair = firstNumStartIndex; firstPair <= firstNumStartIndex + firstNumDiff; firstPair++) {
        for (let secondPair = secondNumStartIndex; secondPair <=secondNumStartIndex + secondDiff; secondPair++) {
            
            for (let i = 2; i < firstPair; i++) {
                if (firstPair % i == 0){
                    IsprimeFirst = false;
                }
                
            }
            for (let j = 2; j < secondPair; j++) {
                
                if (secondPair % j == 0){
                    IsPrimeSecond = false;
                }
            }
            if(IsprimeFirst == true && IsPrimeSecond == true){
                console.log(`${firstPair}${secondPair}`);
            }

            IsprimeFirst = true;
            IsPrimeSecond = true;
        }
        
    }
}

primePairs(["10", "20", "5", "5"]);