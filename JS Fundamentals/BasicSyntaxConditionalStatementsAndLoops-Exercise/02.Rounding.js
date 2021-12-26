function rounding(arg1, arg2){
    let number = Number(arg1);
    let roundingNumber = Number(arg2);

    if (roundingNumber > 15){
        roundingNumber = 15;
    }

    console.log(parseFloat(number.toFixed(roundingNumber)));
}

rounding("3.1", "3");