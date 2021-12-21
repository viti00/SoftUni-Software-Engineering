function profit (input){
    let companyName = input.shift();
    let adultTickets = Number(input.shift());
    let kidTickets = Number(input.shift());
    let adultTicketPrice = Number(input.shift());
    let fee = Number(input.shift());


    let kidTicketPrice = 0.3 * adultTicketPrice + fee;
    let finalAdultTicketPrice = adultTicketPrice + fee;

    let total = finalAdultTicketPrice * adultTickets + kidTickets * kidTicketPrice;

    let finalProfit = 0.2 * total;


    console.log(`The profit of your agency from ${companyName} tickets is ${finalProfit.toFixed(2)} lv.`);
}

profit(["wizzair", "15", "5", "120", "40"]);