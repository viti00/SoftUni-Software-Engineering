function sumPrimeNonPrime(input){
debugger;
    let command = input.shift();
    let primeSum =0;
    let nonPrimeSum = 0;
    let isPrime = true;

    while(command != "stop"){
        let currNum = Number(command);

        if(currNum < 0){
            console.log("Number is negative.");
            command = input.shift();
            continue;
        }
        
        for (let index = 2; index < currNum; index++) {
            if (currNum % index == 0){
                isPrime = false;
                break;
            }
        }

        if (isPrime == true){
            primeSum += currNum;
        }
        else{
            nonPrimeSum += currNum;
        }
        isPrime = true;

        command = input.shift();
    }

    console.log(`Sum of all prime numbers is: ${primeSum}`);
    console.log(`Sum of all non prime numbers is: ${nonPrimeSum}`);
}

sumPrimeNonPrime(["0", "9", "0", "7", "19", "4", "stop"]);