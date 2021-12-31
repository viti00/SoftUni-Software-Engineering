function nextDay(year, month, day) {
    debugger;

    let y = Number(year);
    let m = Number(month);
    let d = Number(day);

    
    let nextDay = new Date(y, m - 1, d + 1);
    let newYear = nextDay.getFullYear();
    let newMonth = nextDay.getMonth() + 1;
    let newDate = nextDay.getDate();
    console.log(`${newYear}-${newMonth}-${newDate}`);
}

nextDay("2016", "9", "30");