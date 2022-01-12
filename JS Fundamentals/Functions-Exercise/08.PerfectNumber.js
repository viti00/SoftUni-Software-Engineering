function perfectNumber(arg){
    let n = Number(arg);
    let sum = divisiorsSum(n);
    if (n == sum){
        console.log(`We have a perfect number!`);
    }
    else {
        console.log(`It's not so perfect.`);
    }

    function divisiorsSum(n){
        let sum = 0;
        for (let i = 1; i <= n - 1; i++) {
            if (n % i == 0){
                sum += i;
            }
        }
        return sum;
    }
}

perfectNumber("28");