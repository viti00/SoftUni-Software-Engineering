function weddingSeats(input){
    debugger;
    let endIndex =input.shift();
    let firstSectorRows = Number(input.shift());
    let oddRowsSeats = Number(input.shift());
    let counter = 0;

    let i = endIndex.charCodeAt(0);

    for (let sectors = 65; sectors <= i; sectors++) {
        for (let row = 1; row <= firstSectorRows; row++) {
            if(row % 2 == 0){
                for (let seat = 97; seat < 97 + oddRowsSeats + 2; seat++) {
                    
                    console.log(`${String.fromCharCode(sectors)}${row}${String.fromCharCode(seat)}`);
                    counter++;
                }
            }
            else if (row % 2 == 1){
                for (let seat = 97; seat < 97 + oddRowsSeats; seat++) {
                    
                    console.log(`${String.fromCharCode(sectors)}${row}${String.fromCharCode(seat)}`);
                    counter++;
                }
            }
        }
        firstSectorRows++;
        
    }
    console.log(counter);
    
}

weddingSeats(["B", "3", "2"]);