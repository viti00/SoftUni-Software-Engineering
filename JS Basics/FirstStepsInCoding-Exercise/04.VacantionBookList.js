function calculateTime(input){
    let pages = Number(input[0]);
    let pagesPerHour = Number(input[1]);
    let days = Number(input[2]);
    
    let neededTime = pages / pagesPerHour;
    let readingTimePerDay = neededTime / days;

    console.log(readingTimePerDay);
}

calculateTime(["212", "20", "2"]);