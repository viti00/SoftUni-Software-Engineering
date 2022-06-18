function solution() {
    debugger;
    let robot = {
        'recepies': {
            apple: { carbohydrate: 1, flavour: 2 },
            lemonade: { carbohydrate: 10, flavour: 20 },
            burger: { carbohydrate: 5, fat: 7, flavour: 3 },
            eggs: { protein: 5, fat: 1, flavour: 1 },
            turkey: { protein: 10, carbohydrate: 10, fat: 10, flavour: 10 }
        },
        'stockQuantity': {
            protein: 0,
            carbohydrate: 0,
            fat: 0,
            flavour: 0
        }
    }

    function functionality(input) {
        let splitted = input.split(' ');
        let [func, element, quantity] = splitted;

        if (func == 'restock') {
            let obj = robot['stockQuantity'];
            obj[element] += Number(quantity);
            return 'Success';
        }
        else if (func == 'prepare') {
            let objStock = robot['stockQuantity'];
            let objRecepi = robot['recepies'][element];

            for (const key in objRecepi) {
                if (objRecepi[key] * Number(quantity) > objStock[key]) {
                    return `Error: not enough ${key} in stock`;
                }
            }

            for (const key in objRecepi) {
                objStock[key] -= Number(objRecepi[key]);
            }

            return `Success`;

        }
        else if (func == 'report'){
            let result = '';
            let objStock = robot['stockQuantity'];
            for (const key in objStock) {
                result += `${key}=${objStock[key]} `;
            }
            return result.trimEnd();
        }
    }

    return functionality;
}

let manager = solution();
console.log(manager("prepare turkey 1")); 
console.log(manager("restock protein 10")); 
console.log(manager("prepare turkey 1"));
console.log(manager("restock carbohydrate 10"));
console.log(manager("prepare turkey 1"));
console.log(manager("restock fat 10"));
console.log(manager("prepare turkey 1"));
console.log(manager("restock flavour 10"));
console.log(manager("prepare turkey 1"));
console.log(manager("report"));


