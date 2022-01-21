function convertToObject(string){
    let myObject = JSON.parse(string);


    for (const el of Object.keys(myObject)) {
        console.log(`${el}: ${myObject[el]}`);
    }
}

convertToObject('{"name": "George", "age": 40, "town": "Sofia"}');