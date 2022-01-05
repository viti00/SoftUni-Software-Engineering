function dayOfWeek(input){
    let daysArr = ["Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"];
    let day = Number(input);

    if (day < 0 || day > daysArr.length){
        console.log("Invalid day!");
    }
    else {
        console.log(daysArr[day - 1]);
    }
}

dayOfWeek("7");