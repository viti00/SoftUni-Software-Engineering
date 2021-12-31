function distance(arg1, arg2, arg3, arg4){

    let x1 = Number(arg1);
    let y1 = Number(arg2);
    let x2 = Number(arg3);
    let y2 = Number(arg4);


    let distance  = Math.sqrt(Math.pow(x2 - x1, 2) + Math.pow(y2 - y1, 2));

    console.log(distance);

}

distance("2", "4", "5", "0");