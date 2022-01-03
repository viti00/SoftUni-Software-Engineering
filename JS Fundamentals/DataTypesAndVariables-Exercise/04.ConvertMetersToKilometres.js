function metersToKilometers(arg1){
    let meters = Number(arg1);

    let kilometers = meters / 1000;

    console.log(kilometers.toFixed(2));

}

metersToKilometers("5000");