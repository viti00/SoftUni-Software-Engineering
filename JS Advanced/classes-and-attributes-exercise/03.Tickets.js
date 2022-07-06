function solve(input, criteria){
    let tickets = [];
    class Ticket{
        constructor(destination, price, status){
            this.destination = destination;
            this.price = price;
            this.status = status;
        }
    }

    for (const data of input) {
        let splitted = data.split('|')
        let[destination, price, status] = splitted;

        tickets.push(new Ticket(destination, Number(price), status));
    }
    let sortedArr = [];
    if(criteria == 'price'){
        sortedArr= tickets.sort((a,b) => a[criteria] - b[criteria]);
    }
    else {
        sortedArr = tickets.sort((a,b) => a[criteria].localeCompare(b[criteria]));
    }

    return sortedArr;
}


console.log(solve(['Philadelphia|94.20|available',
'New York City|95.99|available',
'New York City|95.99|sold',
'Boston|126.20|departed'],
'destination'
));