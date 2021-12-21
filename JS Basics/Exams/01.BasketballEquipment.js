function basketballEquipment(input){
    let fee = Number(input.shift());

    let bootsPrice = fee * 0.6;
    let equipmentPrice = bootsPrice * 0.80;
    let ballPrice = equipmentPrice / 4;
    let accessoriesPrice = ballPrice / 5;


    let totalPrice = fee  + bootsPrice + equipmentPrice + ballPrice + accessoriesPrice;

    console.log(totalPrice.toFixed(2));
}

basketballEquipment(["320"]);