function solve(input){
    debugger;
    input = input.sort((a, b) => a.localeCompare(b));
    let products = {};
    for (const element of input) {
        let [name, price] = element.split(' : ');

        let startsWithLetter = name[0];
        price = Number(price);

        if(!products.hasOwnProperty(startsWithLetter)){
            products[startsWithLetter] = [];
        }

        products[startsWithLetter].push({name, price});
    }

    for (const key in products) {
        console.log(key)
        for (const values of products[key]) {
            console.log(`  ${values.name}: ${values.price}`);
        }
    }
}

solve(['Appricot : 20.4',
'Fridge : 1500',
'TV : 1499',
'Deodorant : 10',
'Boiler : 300',
'Apple : 1.25',
'Anti-Bug Spray : 15',
'T-Shirt : 10']
)