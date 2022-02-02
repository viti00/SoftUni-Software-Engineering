function aMinerTask(arr){
    let resources = {};
    for (let i = 0; i < arr.length; i+= 2) {
        let resource = arr[i];
        let quantity = Number(arr[i + 1]);

        if (resources[resource] == null){
            resources[resource] = quantity;
        }
        else {
            resources[resource] += quantity;
        }
    }

    for (const key in resources) {
        console.log(`${key} -> ${resources[key]}`);
    }
}

aMinerTask([
    'Gold',
    '155',
    'Silver',
    '10',
    'Copper',
    '17'
    ]);