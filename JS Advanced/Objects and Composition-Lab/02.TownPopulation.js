function solve(input){
    let result = {};
    for (const obj of input) {
        let splitted = obj.split(" <-> ");

        let cityName = splitted[0];
        let cityPopulation = Number(splitted[1]);

        if(result.hasOwnProperty(cityName)){
            result[cityName] += cityPopulation;
        }
        else {
            result[cityName] = cityPopulation;
        }
    }

    for (const key in result) {
        console.log(`${key} : ${result[key]}`);
    }
}

solve(['Sofia <-> 1200000',
'Montana <-> 20000',
'New York <-> 10000000',
'Washington <-> 2345000',
'Las Vegas <-> 1000000']
)