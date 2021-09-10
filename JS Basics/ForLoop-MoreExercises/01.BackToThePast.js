function backToThePast(input){
    let money = Number(input[0]);

    let year = Number(input[1]);

    let ivanchoAge = 18;

    let spendMoney = 0.0;


    for (let index = 1800; index <= year; index++) {
        if(index % 2 == 0){
            spendMoney += 12000;
        }
        else {
            spendMoney += 12000 + ivanchoAge * 50;
        }
        ivanchoAge++;
    }


    if (money >= spendMoney){
        let left = money - spendMoney;
        console.log(`Yes! He will live a carefree life and will have ${left.toFixed(2)} dollars left.`);
    }
    else {
        let need = spendMoney - money;
        console.log(`He will need ${need.toFixed(2)} dollars to survive.`);
    }
}

backToThePast(["50000", "1802"]);