function poundsToDolars(arg1){
    let pounds = Number(arg1);

    let dolars = pounds * 1.31;

    console.log(dolars.toFixed(3));
}

poundsToDolars("80");