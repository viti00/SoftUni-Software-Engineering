function workOrWeekenday(input){
    let dayOfWeek = input[0];

    if (dayOfWeek == "Monday" || dayOfWeek == "Tuesday" || dayOfWeek == "Wednesday" || dayOfWeek == "Thursday" || dayOfWeek == "Friday"){
        console.log("Working day");
    }
    else if (dayOfWeek == "Saturday" || dayOfWeek == "Sunday"){
        console.log("Weekend");
    }
    else{
        console.log("Error");
    }
}

workOrWeekenday(["Wednesday"]);