function dishwasher(input){
    let bottlesCount = Number(input.shift());

    let detergentMls = bottlesCount * 750;

    let command = input.shift();

    let counter = 1;

    let cleanPots = 0;
    let cleanDishes = 0;

    while(command != "End" && detergentMls >= 0){

        let vesselsCount = Number(command);
        if(counter % 3 == 0){
            detergentMls -= vesselsCount * 15;
            cleanPots += vesselsCount;
        }
        else{
            detergentMls -= vesselsCount * 5;
            cleanDishes += vesselsCount;
        }

        command = input.shift();
        counter++;
    }

    if (detergentMls >= 0){
        console.log("Detergent was enough!");
        console.log(`${cleanDishes} dishes and ${cleanPots} pots were washed.`);
        console.log(`Leftover detergent ${detergentMls} ml.`);
    }
    else {
        console.log(`Not enough detergent, ${Math.abs(detergentMls)} ml. more necessary!`);
    }
}

dishwasher(["1", "10", "15", "10", "12", "13", "30"]);