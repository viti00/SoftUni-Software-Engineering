function specialNumbers(input){
    let n = Number(input);
    debugger;

    for (let i = 1; i <= n; i++) {
        let number = i;
        let sum = 0;

        while(number != 0){
            let digit = number % 10;
            sum += digit;
            number = parseInt(number / 10);
        }

        if (sum == 5 || sum == 7 || sum == 11){
            console.log(`${i} -> True`)
        }
        else {
            console.log(`${i} -> False`);
        }
        
    }
}

specialNumbers("15");