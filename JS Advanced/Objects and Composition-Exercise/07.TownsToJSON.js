function solve(input){
    input.shift();
    debugger;
    let towns = [];
    for (const element of input) {
        let [Town, Latitude, Longitude] = element.split(/\s*\|\s*/).filter(Boolean);

        Latitude = +Number(Latitude).toFixed(2);
        Longitude = +Number(Longitude).toFixed(2);

        towns.push({Town, Latitude, Longitude});
    }

    console.log(JSON.stringify(towns));
}

solve(['| Town | Latitude | Longitude |',
'| Sofia | 42.696552 | 23.32601 |',
'| Beijing | 39.913818 | 116.363625 |']
)