function leapYears(input){
    let leapYear = Number(input[0]);
    let borderYear = Number(input[1]);


    for (let index = leapYear; index <= borderYear; index +=4) {
        console.log(index);
        
    }
}

leapYears(["1908", "1919"]);