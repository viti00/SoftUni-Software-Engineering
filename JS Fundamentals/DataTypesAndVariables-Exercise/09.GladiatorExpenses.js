function gladiatorExpense(arg1, arg2, arg3, arg4, arg5){
    let lostFightCounts = Number(arg1);
    let helmedPrice = Number(arg2);
    let swordPrice = Number(arg3);
    let shieldPrice = Number(arg4);
    let armourPrice = Number(arg5);
    
    let brokenShieldCount = 0;
    
    let cost = 0;
    for (let i = 1; i <= lostFightCounts; i++) {
        
        if (i % 2 == 0){
            cost += helmedPrice;
        }
        if(i% 3 == 0){
            cost += swordPrice;
        }
        if(i % 2 == 0 && i % 3 == 0){
            cost += shieldPrice;
            brokenShieldCount++;
        }
        if (brokenShieldCount == 2){
            cost += armourPrice;
            brokenShieldCount = 0;
        }
    }

    console.log(`Gladiator expenses: ${cost.toFixed(2)} aureus`);
}

gladiatorExpense("7", "2", "3", "4", "5");