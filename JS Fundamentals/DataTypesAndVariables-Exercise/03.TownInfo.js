function townInfo(arg1, arg2, arg3){

    let townName = arg1;
    let population = Number(arg2);
    let area = Number(arg3);

    console.log(`Town ${townName} has population of ${population} and area ${area} square km.`);
}

townInfo("Petrich", "70000", "120");