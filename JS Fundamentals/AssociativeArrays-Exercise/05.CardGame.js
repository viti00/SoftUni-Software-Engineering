function cardGame(arr){
    let map = new Map();
    let points = new Map();
    for (const data of arr) {
        let dataArr = data.split(": ");
        let name = dataArr[0];
        let cardArr = dataArr[1].split(", ");

        if (!map.has(name)){
            map.set(name, []);
        }

        for (let i = 0; i < cardArr.length; i++) {
            let arr = map.get(name);

            if (!arr.includes(cardArr[i])){
                map.set(name, map.get(name).concat(cardArr[i]));
            }
        }
    }
    debugger;

    let peopleArr = Array.from(map.entries());

    for (const people of peopleArr) {
        let currPeoplePoints =0;
        for (const points of people[1]) {
            let cardType = points[points.length - 1];
            let power = "";
            if (points.length == 3){
                power = points[0] + points[1];    	
            }
            else if (points.length == 2){
                power = points[0];
            }
            
            currPeoplePoints += calculatePoints(cardType, power);
        }
        points.set(people[0], currPeoplePoints);
    }

    let array = Array.from(points.entries());
    for (const el of array) {
        console.log(`${el[0]}: ${el[1]}`);
    }

    function calculatePoints(cardType, power){
        let currPower = 0;
        let typePower = 0;
        if (power >= 2  && power <= 10){
            currPower = Number(power);
        }
        else if (power == "J"){
            currPower = 11;
        }
        else if (power == "Q"){
            currPower = 12;
        }
        else if (power == "K"){
            currPower = 13;
        }
        else if (power == "A"){
            currPower = 14;
        }

        if (cardType == "S"){
            typePower  = 4;
        }
        else if (cardType == "H"){
            typePower = 3;
        }
        else if (cardType == "D"){
            typePower = 2;
        }
        else if (cardType == "C"){
            typePower = 1;
        }

        return currPower * typePower;
    }
}

cardGame([
    'Peter: 2C, 4H, 9H, AS, QS',
    'Tomas: 3H, 10S, JC, KD, 5S, 10S',
    'Andrea: QH, QC, QS, QD',
    'Tomas: 6H, 7S, KC, KD, 5S, 10C',
    'Andrea: QH, QC, JS, JD, JC',
    'Peter: JD, JD, JD, JD, JD, JD'
    ]);