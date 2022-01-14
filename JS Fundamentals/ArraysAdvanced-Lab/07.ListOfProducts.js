function listOfProdocuts(arr){

    arr = arr.sort();
    let i = 1;

    for (const el of arr) {
        
        console.log(`${i}.${el}`);
        i++;
    }
}

listOfProdocuts(["Potatoes", "Tomatoes", "Onions", "Apples"]);