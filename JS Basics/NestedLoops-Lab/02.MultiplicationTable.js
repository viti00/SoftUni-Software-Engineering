function multiplicationTable(){
    for (let number = 1; number <= 10; number++) {
        
        for (let secondNumber = 1; secondNumber <= 10; secondNumber++) {
            
            console.log(`${number} * ${secondNumber} = ${number * secondNumber}`);
        }
    }
}

multiplicationTable();