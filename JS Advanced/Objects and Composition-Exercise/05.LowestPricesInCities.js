function solve(input){
    let obj = {};
    debugger;

    for (const element of input) {
        let [town, product, price] = element.split(' | ');

        price = Number(price);

        if(obj.hasOwnProperty(product)){
            if(obj[product].price > price){
                obj[product].price = price;
                obj[product].town = town;
            }
        }
        else {
            obj[product] = {price, town};
        }
    }

    for (const key in obj) {
        console.log(`${key} -> ${obj[key].price} (${obj[key].town})`);
    }
}

solve(['Sample Town | Sample Product | 1000',
'Sample Town | Orange | 2',
'Sample Town | Peach | 1',
'Sofia | Orange | 3',
'Sofia | Peach | 2',
'New York | Sample Product | 1000.1',
'New York | Burger | 10']
)