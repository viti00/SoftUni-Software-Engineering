function fuelMoney(arg1, arg2, arg3){
    let distance = Number(arg1);
    let passengers = Number(arg2);
    let fuelCost = Number(arg3);

    let increaseFuel = passengers * 0.100;
    let consumtionPer100Km = (distance / 100) * (7 + increaseFuel);
    let totalMoney = consumtionPer100Km * fuelCost;

    console.log(`Needed money for that trip is ${totalMoney.toFixed(2)}lv.`);
}

fuelMoney("260", "9", "2.49")