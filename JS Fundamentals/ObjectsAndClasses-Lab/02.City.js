function city(obj){
    let myObj = obj;

    for (const obj of Object.keys(myObj)) {
        console.log(`${obj} -> ${myObj[obj]}`);
    }
}

city({
    name: "Sofia",
    area: 492,
    population: 1238438,
    country: "Bulgaria",
    postCode: "1000"
}
);