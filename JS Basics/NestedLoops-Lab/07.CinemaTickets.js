function cinemaTickets (input){
    debugger;
    let standartCount = 0;
    let kidCount = 0;
    let StudentCount = 0;


    let command = input.shift();

    while(command != "Finish"){

        let movieName = command;
        let rows = Number(input.shift());
        let currFilmTicketsCount = 0;

        let ticketType = input.shift();
        while(ticketType != "End"){
            let currTicket = ticketType;

            switch(currTicket){
                case"standard":
                    standartCount++;
                break;
                case"kid":
                    kidCount++;
                break;
                case"student": 
                    StudentCount++;
                break;
            }
            currFilmTicketsCount++;
            if(currFilmTicketsCount == rows){
                break;
            }
            ticketType = input.shift();
        }
        let fullPercent = currFilmTicketsCount / rows * 100;
        console.log(`${movieName} - ${fullPercent.toFixed(2)}% full.`);
        currFilmTicketsCount = 0;

        command = input.shift();
    }
    let totalSoldTickets = standartCount + kidCount + StudentCount;

    let standartPercent = standartCount / totalSoldTickets * 100;
    let kidPercent = kidCount / totalSoldTickets * 100;
    let studentPercent = StudentCount / totalSoldTickets * 100;
    console.log(`Total tickets: ${totalSoldTickets}`);
    console.log(`${studentPercent.toFixed(2)}% student tickets.`);
    console.log(`${standartPercent.toFixed(2)}% standard tickets.`);
    console.log(`${kidPercent.toFixed(2)}% kids tickets.`); 
}

cinemaTickets(["Taxi", "10", "standard", "kid", "student", "student", "standard", "standard", "End", "Scary movie", "6", "student", "student", "student", "student", "student", "student", "Finish"]);