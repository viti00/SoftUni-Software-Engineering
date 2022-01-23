function storeProvision(arr1, arr2) {
    let myObj = {};

    for (let j = 0; j < arr1.length ; j += 2) {
        let product = arr1[j];
        let count = Number(arr1[j + 1]);
        myObj[product] = count;

        
    }

    for (let i = 0; i < arr2.length; i += 2) {
        let name = arr2[i];
        let quantity = Number(arr2[i + 1]);

        if (checkProduct(name) == true){
            myObj[name] += quantity;
        }
        else {
            myObj[name] = quantity;
        }
        
    }

    

    for (const product of Object.keys(myObj)) {
        console.log(`${product} -> ${myObj[product]}`);
    }

    function checkProduct(currProduct){
        for (const product of Object.keys(myObj)) {
            if (product == currProduct){
                return true;
            }
        }
        return false;
    }
}

storeProvision([
    'Chips', '5', 'CocaCola', '9', 'Bananas', '14', 'Pasta', '4', 'Beer', '2'
],
    [
        'Flour', '44', 'Oil', '12', 'Pasta', '7', 'Tomatoes', '70', 'Bananas', '30'
    ]
);