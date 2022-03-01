function pirates(arr) {
    let command = arr.shift();

    let cities = new Map();
    debugger;

    while (command != "Sail") {
        let curr = command.split("||");
        let name = curr[0];
        let population = Number(curr[1]);
        let gold = Number(curr[2]);

        if (!cities.has(name)) {
            cities.set(name, [population, gold]);
        }
        else {
            let oldPopulation = cities.get(name)[0];
            let oldGold = cities.get(name)[1];
            cities.set(name, [oldPopulation + population, oldGold + gold]);
        }

        command = arr.shift();
    }

    let action = arr.shift();
    while (action != "End") {
        let currCmd = action.split("=>");
        if (currCmd[0] == "Plunder") {
            let name = currCmd[1];
            let killedPeople = Number(currCmd[2]);
            let stolenGold = Number(currCmd[3]);

           if (cities.has(name)){
            let oldPopulation = cities.get(name)[0];
            let oldGold = cities.get(name)[1];

            cities.set(name, [oldPopulation - killedPeople, oldGold - stolenGold]);

            console.log(`${name} plundered! ${stolenGold} gold stolen, ${killedPeople} citizens killed.`);

            if ((population = cities.get(name)[0]) == 0 || (gold = cities.get(name)[1]) == 0) {
                console.log(`${name} has been wiped off the map!`)
                cities.delete(name);
            }
           }
        }
        else if (currCmd[0] == "Prosper"){
            let cityName = currCmd[1];
            let addedGold = Number(currCmd[2]);

            if (cities.has(cityName)){
                if (addedGold >= 0){
                    let pop = cities.get(cityName)[0];
                    let gold = cities.get(cityName)[1];
                    cities.set(cityName, [pop, gold + addedGold]);
                    console.log(`${addedGold} gold added to the city treasury. ${cityName} now has ${cities.get(cityName)[1]} gold.`)
    
                }
                else {
                    console.log(`Gold added cannot be a negative number!`);
                }
            }
        }
        action = arr.shift();
    }

    let sorted = Array.from(cities.entries()).sort((a, b) => b[1][1] - a[1][1]);
    console.log(`Ahoy, Captain! There are ${sorted.length} wealthy settlements to go to:`)

    for (const city of sorted.sort((a,b) => a[0] - b[0])) {
        console.log(`${city[0]} -> Population: ${city[1][0]} citizens, Gold: ${city[1][1]} kg`);
    }
}

pirates((["Nassau||95000||1000",
"San Juan||930000||1250",
"Campeche||270000||690",
"Port Royal||320000||1000",
"Port Royal||100000||2000",
"Sail",
"Prosper=>Port Royal=>-200",
"Plunder=>Nassau=>94000=>750",
"Plunder=>Nassau=>1000=>150",
"Plunder=>Campeche=>150000=>690",
"End"]));