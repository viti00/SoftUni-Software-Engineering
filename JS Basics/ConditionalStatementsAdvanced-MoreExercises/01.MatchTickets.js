function matchTickets(input){
    let budget = Number(input[0]);
    let ticketType = input[1];
    let peopleCount = Number(input[2]);
    
    let transportPrice = 0.0;

    if (peopleCount >= 1 && peopleCount <= 4){
        transportPrice = budget * 0.75;
    }
    else if (peopleCount >= 5 && peopleCount <= 9){
        transportPrice = budget * 0.60;
    }
    else if (peopleCount >= 10 && peopleCount <= 24){
        transportPrice = budget * 0.50;
    }
    else if (peopleCount >= 25 && peopleCount <= 49){
        transportPrice = budget * 0.40;
    }
    else if (peopleCount >= 50){
        transportPrice = budget * 0.25;
    }

    let totalSum = 0.0;
    if (ticketType == "VIP"){
        totalSum = peopleCount * 499.99 + transportPrice;
    }
    else if (ticketType == "Normal"){
        totalSum = peopleCount * 249.99 + transportPrice;
    }

    if (totalSum > budget){
        let need = totalSum - budget;
        console.log(`Not enough money! You need ${need.toFixed(2)} leva.`);
    }
    else{
        let left = budget - totalSum;
        console.log(`Yes! You have ${left.toFixed(2)} leva left.`);
    }
}

matchTickets(["1000", "Normal", "1"]);