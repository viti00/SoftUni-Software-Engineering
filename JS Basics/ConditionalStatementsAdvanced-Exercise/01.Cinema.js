function solve(input){
    let ticketType = input[0];

    let rows = Number(input[1]);
    let cols = Number(input[2]);

    let totalSeats = rows*cols;
    let totalSum = 0.0;
    if (ticketType == "Premiere"){
        totalSum = totalSeats * 12.00;
    }
    else if (ticketType == "Normal"){
        totalSum = totalSeats * 7.50;
    }
    else if (ticketType == "Discount"){
        totalSum = totalSeats * 5;
    }

    console.log(`${totalSum.toFixed(2)} leva`);
}

solve(["Premiere", "10", "12"]);
