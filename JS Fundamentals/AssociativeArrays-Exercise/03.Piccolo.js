function piccolo(arr){
    debugger;
    let cars = [];
    for (const data of arr) {
        let dataArr = data.split(", ");

        let direction = dataArr[0];
        let number = dataArr[1];

        if (direction == "IN"){
            if (!cars.includes(number)){
                cars.push(number);
            }
        }
        else if (direction == "OUT"){
            if (cars.includes(number)){
                let index = cars.indexOf(number);
                cars.splice(index, 1);
            }
        }
    }

    cars = cars.sort();

    if (cars.length == 0){
        console.log(`Parking Lot is Empty`);
    }
    else {
        console.log(cars.join("\n"));
    }
}

piccolo(['IN, CA2844AA',
'IN, CA1234TA',
'OUT, CA2844AA',
'IN, CA9999TT',
'IN, CA2866HI',
'OUT, CA1234TA',
'IN, CA2844AA',
'OUT, CA2866HI',
'IN, CA9876HH',
'IN, CA2822UU']);