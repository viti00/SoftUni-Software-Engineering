function travelTime(arr){
    let destinations = {};
    for (const data of arr) {
        let dataArr = data.split(" > ");
        let countryName = dataArr[0];
        let destination = dataArr[1];
        let cost = Number(dataArr[2]);

        if(destinations[countryName] == null){
            destinations[countryName] = {};
        }

        if (destinations[countryName][destination] == null){
            destinations[countryName][destination] = cost;
        }
        else {
            let currCost = destinations[countryName][destination];

            if (currCost <= cost){
                destinations[countryName][destination] = currCost;
            }
            else{
                destinations[countryName][destination] = cost;
            }
        }
    }
    debugger;

    let orderedCountries = [...Object.keys(destinations)].sort((a,b) => a.localeCompare(b));
    let result = "";
    for (let country of orderedCountries) {
        result += country + " -> ";
        let sortedPrices = [...Object.keys(destinations[country])].sort((a, b) => travelCost(a, b, destinations, country));
        for (let town of sortedPrices) {
            result += `${town} -> ${destinations[country][town]} `;
        }
        result += "\n";
    }
    console.log(result);

    
    function travelCost(town1, town2, destination, country) {
        let priceOne = destination[country][town1];
        let priceTwo = destination[country][town2];
 
        return priceOne - priceTwo
    }
}

travelTime([
    "Bulgaria > Sofia > 500",
    "Bulgaria > Sopot > 800",
    "France > Paris > 2000",
    "Albania > Tirana > 1000",
    "Bulgaria > Sofia > 200"
    ]);