function profit(input){

    let oneLevCount = Number(input.shift());
    let twoLevaCount = Number(input.shift());
    let fiveLevaCount = Number(input.shift());
    let nededSum = Number(input.shift());

    for (let oneLev = 0; oneLev <= oneLevCount; oneLev++) {
        for (let twoLeva = 0; twoLeva <= twoLevaCount; twoLeva++) {
            for (let fiveLeva = 0; fiveLeva <= fiveLevaCount; fiveLeva++) {
                
                let sum = oneLev * 1 + twoLeva * 2 + fiveLeva * 5;
                if (sum == nededSum){
                    console.log(`${oneLev} * 1 lv. + ${twoLeva} * 2 lv. + ${fiveLeva} * 5 lv. = ${nededSum} lv.`);
                }
                
            }
            
        }
        
    }
}

profit(["3", "2", "3", "10"]);