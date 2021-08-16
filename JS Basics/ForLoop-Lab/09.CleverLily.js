function cleverLily(input){
    let lilyAge = Number(input[0]);
    let laundryPrice = Number(input[1]);
    let pricePerToy = Number(input[2]);

    let sum = 0.0;
    let toyCount = 0;
    let money = 10;

    for (let index = 1; index <= lilyAge; index++) {
        if(index % 2 == 1){
            toyCount++;
        }
        else if(index % 2 == 0){
            sum += (money - 1);
            money += 10;
        }
        
    }

    sum += toyCount * pricePerToy;

    if(sum >= laundryPrice){
        let left = sum - laundryPrice;
        console.log(`Yes! ${left.toFixed(2)}`);
    }   
    else{
        let need = laundryPrice - sum;
        console.log(`No! ${need.toFixed(2)}`);
    }
}

cleverLily(["10", "170", "6"]);