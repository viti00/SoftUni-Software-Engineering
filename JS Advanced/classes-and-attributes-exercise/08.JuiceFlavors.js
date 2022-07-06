function solve(products){
    let map = new Map();
    let bottleMap = new Map();
    for (const product of products) {
        let splitted = product.split(' => ');
        let productName = splitted[0];
        let productQuantity = Number(splitted[1]);
        if(!map.has(productName)){
            map.set(productName, 0);
        }

        map.set(productName, map.get(productName) + productQuantity);

        if(map.get(productName) >= 1000){
            let bottles = Math.floor(map.get(productName) / 1000);

            map.set(productName, map.get(productName) - (bottles * 1000));

            if(!bottleMap.has(productName)){
                bottleMap.set(productName, 0);
            }
            
            bottleMap.set(productName, bottleMap.get(productName) + bottles);
        }
    }

    let entries = Array.from(bottleMap.entries());

    entries.forEach(e => {
        console.log(`${e[0]} => ${e[1]}`);
    });
}

debugger;
solve(['Orange => 2000',
'Peach => 1432',
'Banana => 450',
'Peach => 600',
'Strawberry => 549'])
