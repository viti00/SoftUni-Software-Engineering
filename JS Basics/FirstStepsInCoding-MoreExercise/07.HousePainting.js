function calcolateNeededPaint(input){
    let x = Number(input[0]);
    let y = Number(input[1]);
    let h = Number(input[2]);

    let lateral = x*y;
    let window = 1.5 * 1.5;

    let lateralSidesTotal = lateral * 2 - window * 2;

    let backSide = x*x;

    let door = 1.2 * 2;

    let totalFrontAndBackSides = backSide * 2 - door;

    let totalSides = lateralSidesTotal + totalFrontAndBackSides;

    let neededGreenPaint = totalSides / 3.4;

    let roofUper = 2 * (x * y);
    let roofBasis = 2 * (x * h / 2);

    let roofTotal = roofUper + roofBasis;

    let neededRedPaint = roofTotal / 4.3;

    console.log(neededGreenPaint.toFixed(2));
    console.log(neededRedPaint.toFixed(2));
}

calcolateNeededPaint(["6", "10", "5.2"]);