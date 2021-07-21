function calculateDeposit(input){
    let deposit = Number(input[0]);
    let term = Number(input[1]);
    let divident = Number(input[2]);

    let sum = deposit + term * ((deposit * (divident/100))/ 12);

    console.log(sum);
}

calculateDeposit(["200", "3", "5.7"]);