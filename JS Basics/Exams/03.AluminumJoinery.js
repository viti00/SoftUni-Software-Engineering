function aluminumJoinery(input){
    let joineryCount = Number(input.shift());

    let size = input.shift();

    let withDeliveryOrNot = input.shift();

    let price = 0;

    if (joineryCount  < 10){
        console.log(`Invalid order`);
    }
    else {
        switch(size){
            case"90X130":
                price = joineryCount * 110;
                if (joineryCount > 30 && joineryCount <= 60){
                    price -= price * 0.05;
                }
                else if (joineryCount > 60){
                    price -= price * 0.08;
                }
            break;
            case"100X150":
                price = joineryCount * 140;
                if (joineryCount > 40 && joineryCount <= 80){
                    price -= price * 0.06;
                }
                else if (joineryCount > 80){
                    price -= price * 0.1;
                }
            break;
            case"130X180":
                price = joineryCount * 190; 
                if (joineryCount > 20 && joineryCount <= 50){
                    price -= price * 0.07;
                }
                else if (joineryCount > 50){
                    price -= price * 0.12;
                }
            break;
            case"200X300":
                price = joineryCount * 250;
                if (joineryCount > 25 && joineryCount <= 50){
                    price -= price * 0.09;
                }
                else if (joineryCount > 50){
                    price -= price * 0.14;
                }
            break;
        }

        if (withDeliveryOrNot == "With delivery"){
            price += 60;
        }

        if (joineryCount > 99){
            price -= price * 0.04;
        }

        console.log(`${price.toFixed(2)} BGN`);
    }
    
}

aluminumJoinery(["40", 
"90X130",
"Without delivery"]);
