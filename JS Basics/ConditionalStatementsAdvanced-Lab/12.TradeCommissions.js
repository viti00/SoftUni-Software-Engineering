function tradeCommission(input){
    let city = input[0];
    let sells = Number(input[1]);

    let commission = 0.0;

    if (city == "Sofia"){
        if (sells >= 0 && sells <= 500){
            commission = sells * 0.05;
            console.log(commission.toFixed(2));
        }
        else if (sells > 500 && sells <= 1000){
            commission = sells * 0.07;
            console.log(commission.toFixed(2));
        }
        else if (sells > 1000 && sells <= 10000){
            commission = sells * 0.08;
            console.log(commission.toFixed(2));
        }
        else if (sells > 10000){
            commission = sells * 0.12;
            console.log(commission.toFixed(2));
        }
        else {
            console.log("error");
        }
        
    }
    else if (city == "Plovdiv"){
        if (sells >= 0 && sells <= 500){
            commission = sells * 0.055;
            console.log(commission.toFixed(2));
        }
        else if (sells > 500 && sells <= 1000){
            commission = sells * 0.08;
            console.log(commission.toFixed(2));
        }
        else if (sells > 1000 && sells <= 10000){
            commission = sells * 0.12;
            console.log(commission.toFixed(2));
        }
        else if (sells > 10000){
            commission = sells * 0.145;
            console.log(commission.toFixed(2));
        }
        else {
            console.log("error");
        }
    }
    else if (city == "Varna"){
        if (sells >= 0 && sells <= 500){
            commission = sells * 0.045;
            console.log(commission.toFixed(2));
        }
        else if (sells > 500 && sells <= 1000){
            commission = sells * 0.075;
            console.log(commission.toFixed(2));
        }
        else if (sells > 1000 && sells <= 10000){
            commission = sells * 0.1;
            console.log(commission.toFixed(2));
        }
        else if (sells > 10000){
            commission = sells * 0.13;
            console.log(commission.toFixed(2));
        }
        else {
            console.log("error");
        }
    }
    else{
        console.log("error");
    }
}
tradeCommission(["Sofia", "1500"]);