function mathPower(arg1, arg2){
    let number = Number(arg1);
    let pow = Number(arg2);

    console.log(power(number, pow));

    function power(number, pow){
        let result = Math.pow(number, pow);

        return result;
    }
}

mathPower("2", "8");