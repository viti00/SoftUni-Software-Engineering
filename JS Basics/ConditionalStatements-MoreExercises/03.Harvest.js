function hearvest(input){
    let x = Number(input[0]);
    let y = Number(input[1]);
    let z = Number(input[2]);
    let workersCount = Number(input[3]);

    let totalGrape = x * y;

    let vine = 0.4 * totalGrape / 2.5;

    if (vine >= z){
        let leftVine = vine - z;
        let vinePerWorker = leftVine / workersCount;

        console.log(`Good harvest this year! Total wine: ${Math.floor(vine)} liters.`);
        console.log(`${Math.ceil(leftVine)} liters left -> ${Math.ceil(vinePerWorker)} liters per person.`);
    }
    else {
        let needed = z - vine;
        console.log(`It will be a tough winter! More ${Math.floor(needed)} liters wine needed.`);
    }
}

hearvest(["650", "2", "175", "3"]);