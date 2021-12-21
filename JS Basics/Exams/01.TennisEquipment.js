function tennisEquipment(input){
    let tennisRocketPrice = Number(input.shift());

    let tennisRocketsCount = Number(input.shift());
    let bootsCount = Number(input.shift());

    let bootsPrice = tennisRocketPrice / 6;

    let equipmentCost = tennisRocketPrice * tennisRocketsCount + bootsPrice * bootsCount;

    let otherEquipment = 0.2 * equipmentCost;

    let total = equipmentCost + otherEquipment;

    let DjokovicSum = total / 8;

    let sponsorsSum = total * (7 / 8);

    console.log(`Price to be paid by Djokovic ${Math.floor(DjokovicSum)}`);
    console.log(`Price to be paid by sponsors ${Math.ceil(sponsorsSum)}`);
}


tennisEquipment(["850",
"4",
"2"]);
