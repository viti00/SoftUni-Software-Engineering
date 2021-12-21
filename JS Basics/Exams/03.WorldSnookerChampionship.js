function tickets (input){
    let stage = input.shift();
    let ticketType = input.shift();
    let ticketsCount = Number(input.shift());
    let photo = input.shift();
    let cost = 0;
    

    switch(stage){
        case"Quarter final":
            switch(ticketType){
                case "Standard":
                    cost = ticketsCount * 55.50;
                break;
                case"Premium":
                    cost = ticketsCount * 105.20;
                break;
                case"VIP":
                    cost = ticketsCount * 118.90;
                break;
            }
        break;
        case"Semi final":
            switch(ticketType){
                case "Standard":
                    cost = ticketsCount * 75.88;
                break;
                case"Premium":
                    cost = ticketsCount * 125.22;
                break;
                case"VIP":
                    cost = ticketsCount * 300.40;
                break;
            }
        break;
        case"Final":
            switch(ticketType){
                case "Standard":
                    cost = ticketsCount * 110.10;
                break;
                case"Premium":
                    cost = ticketsCount * 160.66;
                break;
                case"VIP":
                    cost = ticketsCount * 400;
                break;
            }
        break;
    }

    if (cost > 4000){
        cost *= 0.75;
    }
    else if (cost > 2500 && cost <= 4000){
        cost *= 0.9;
        if (photo == "Y"){
            cost += ticketsCount * 40;
        }
    }
    else if(cost <= 2500){
        if (photo == "Y"){
            cost += ticketsCount * 40;
        }
    }

    console.log(cost.toFixed(2));
}

tickets(["Final",
"Premium",
"25",
"Y"]);
