function smallShop(input){
    let product = input[0];
    let city = input[1];
    let count = Number(input[2]);
    let cost = 0.0;
    switch(city){
        case "Sofia":
            switch(product){
                case"coffee":
                cost = count * 0.50;
                break;
                case"water":
                cost = count * 0.80;
                break;
                case"beer":
                cost = count * 1.20;
                break;
                case"sweets":
                cost = count * 1.45;
                break;
                case"peanuts":
                cost = count * 1.60;
                break;
            }
            break;
        case "Varna":
            switch(product){
                case"coffee":
                cost = count * 0.45;
                break;
                case"water":
                cost = count * 0.70;
                break;
                case"beer":
                cost = count * 1.10;
                break;
                case"sweets":
                cost = count * 1.35;
                break;
                case"peanuts":
                cost = count * 1.55;
                break;
            }
            break;
        case"Plovdiv":
        switch(product){
            case"coffee":
            cost = count * 0.40;
            break;
            case"water":
            cost = count * 0.70;
            break;
            case"beer":
            cost = count * 1.15;
            break;
            case"sweets":
            cost = count * 1.30;
            break;
            case"peanuts":
            cost = count * 1.50;
            break;
        }
        break;
    }
    console.log(cost);
}

smallShop(["coffee", "Varna", "2"]);