function towns(arr){
    let towns = [];
    debugger;

    class Town{
        constructor(name, latitude, longitude){
            this.name = name;
            this.latitude = Number(latitude);
            this.longitude = Number(longitude);
        }
    }

    for (let i = 0; i < arr.length; i++) {
        let cityData = arr[i].split(" | ");

        let name = cityData[0];
        let latitude= Number(cityData[1]);
        let longitude = Number(cityData[2]);

        towns.push(new Town(name, latitude, longitude));
    }


    for (const town of towns) {
        console.log(`{ town: '${town.name}', latitude: '${town.latitude.toFixed(2)}', longitude: '${town.longitude.toFixed(2)}' }`);
    }
}
towns(['Sofia | 42.696552 | 23.32601',
'Beijing | 39.913818 | 116.363625']
);