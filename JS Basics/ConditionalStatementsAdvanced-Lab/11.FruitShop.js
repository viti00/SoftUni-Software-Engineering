function fruitShop(input){
    let product = input[0];
    let day = input[1];
    let count = Number(input[2]);

    let cost = 0.0;

    if (day == "Monday" || day == "Tuesday" || day == "Wednesday" || day == "Thursday" || day == "Friday"){
        switch(product){
            case"banana":
                cost = count * 2.50;
                console.log(cost.toFixed(2));
            break;
            case"apple":
                cost = count * 1.20;
                console.log(cost.toFixed(2));
            break;
            case"orange":
                cost = count * 0.85;
                console.log(cost.toFixed(2));
            break;
            case"grapefruit":
                cost = count * 1.45;
                console.log(cost.toFixed(2));
            break;
            case"kiwi":
                cost = count * 2.70;
                console.log(cost.toFixed(2));
            break;
            case"pineapple":
                cost = count * 5.50;
                console.log(cost.toFixed(2));
            break;
            case"grapes":
                cost = count * 3.85;
                console.log(cost.toFixed(2));
            break;
            default:
                console.log("error");
            break;
        }
    }
    else if (day == "Saturday" || day == "Sunday"){
        switch(product){
            case"banana":
                cost = count * 2.70;
                console.log(cost.toFixed(2));
            break;
            case"apple":
                cost = count * 1.25;
                console.log(cost.toFixed(2));
            break;
            case"orange":
                cost = count * 0.90;
                console.log(cost.toFixed(2));
            break;
            case"grapefruit":
                cost = count * 1.60;
                console.log(cost.toFixed(2));
            break;
            case"kiwi":
                cost = count * 3.00;
                console.log(cost.toFixed(2));
            break;
            case"pineapple":
                cost = count * 5.60;
                console.log(cost.toFixed(2));
            break;
            case"grapes":
                cost = count * 4.20;
                console.log(cost.toFixed(2));
            break;
            
            default:
                console.log("error");
            break;
        }
    }
    else{
        console.log("error");
    }
}

fruitShop(["tomato", "Monday", "0.5"]);