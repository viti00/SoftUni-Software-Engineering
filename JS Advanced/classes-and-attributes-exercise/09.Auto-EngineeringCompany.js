function solve(input){
    let map = new Map();
    for (const car of input) {
        let splitted = car.split(' | ');
        let[brand, model, producedCar] = splitted;

        if(!map.has(brand)){
            map.set(brand, new Map());
        }

        if(map.get(brand).has(model)){
            map.set(brand, map.get(brand).set(model, map.get(brand).get(model) + Number(producedCar)));
        }
        else {
            map.set(brand, map.get(brand).set(model, Number(producedCar)));
        }
        
    }

    let entries = Array.from(map.entries());

    for (const entry of entries) {
        console.log(entry[0]);
        let entriesCars = Array.from(entry[1].entries());
        for (const car of entriesCars) {
            console.log(`###${car[0]} -> ${car[1]}`);
        }
    }
}
debugger;
solve(['Audi | Q7 | 1000',
'Audi | Q6 | 100',
'BMW | X5 | 1000',
'BMW | X6 | 100',
'Citroen | C4 | 123',
'Volga | GAZ-24 | 1000000',
'Lada | Niva | 1000000',
'Lada | Jigula | 1000000',
'Citroen | C4 | 22',
'Citroen | C5 | 10']
)