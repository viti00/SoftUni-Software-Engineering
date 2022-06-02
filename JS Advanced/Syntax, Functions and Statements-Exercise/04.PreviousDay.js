function solve(year, month, day){
    let getYear = new Date(year, month, day - 1).getFullYear();
    let getMonth = new Date(getYear, month, day - 1).getMonth();
    let getDay = new Date(getYear, getMonth, day - 1).getDate();

    console.log(`${getYear}-${getMonth}-${getDay}`);
}

solve(2016, 10, 1)