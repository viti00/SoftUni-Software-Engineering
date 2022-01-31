function storage(arr){
    debugger;
    let map = new Map();

    for (const data of arr) {
        let dataArr = data.split(" ");
        let product = dataArr[0];
        let quantity = Number(dataArr[1]);

        if(!map.has(product)){
            map.set(product, quantity);
        }
        else {
            let currQuantity = map.get(product);
            let newQuantity = currQuantity += quantity;
            map.set(product, newQuantity);
        }
    }

    for (const kvp of map) {
        console.log(`${kvp[0]} -> ${kvp[1]}`);   
    }

}

storage(['tomatoes 10',
'coffee 5',
'olives 100',
'coffee 40']);