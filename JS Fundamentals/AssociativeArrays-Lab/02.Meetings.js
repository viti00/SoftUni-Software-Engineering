function meeting(arr){
    let meeting = {};
    for (const data of arr) {
        let dataArr = data.split(" ");

        let day = dataArr[0];
        let name = dataArr[1];

        if (meeting[day] == null){
            console.log(`Scheduled for ${day}`);
            meeting[day] = name;
        }
        else {
            console.log(`Conflict on ${day}!`);
        }
    }

    for (const key in meeting) {
        console.log(`${key} -> ${meeting[key]}`);
    }
}

meeting(['Monday Peter',
'Wednesday Bill',
'Monday Tim',
'Friday Tim']);