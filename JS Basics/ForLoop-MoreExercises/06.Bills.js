function bills(input){
    let n  = Number(input.shift());

    let electricityBill = 0.0;
    let waterBill = 0.0;
    let internetBill = 0.0;
    let otherBill = 0.0;

    for (let index = 0; index < n; index++) {
        let electricity = Number(input[index]);
        electricityBill += electricity;
        waterBill += 20;
        internetBill += 15;
        otherBill += (electricity  + 20 + 15) * 1.2;
    }

    let average = (electricityBill + waterBill + internetBill + otherBill) / n;

    console.log(`Electricity: ${electricityBill.toFixed(2)} lv`);
    console.log(`Water: ${waterBill.toFixed(2)} lv`);
    console.log(`Internet: ${internetBill.toFixed(2)} lv`);
    console.log(`Other: ${otherBill.toFixed(2)} lv`);
    console.log(`Average: ${average.toFixed(2)} lv`);
}

bills(["5", "68.63", "89.25", "132.53", "93.53", "63.22"]);