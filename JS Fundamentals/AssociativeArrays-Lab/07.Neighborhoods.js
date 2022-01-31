function neighborhood(arr) {

    let names = arr.shift().split(", ");

    let map = new Map();

    for (const name of names) {
        map.set(name, []);
    }

    for (const data of arr) {
        let dataArr = data.split(" - ");
        let name = dataArr[0];
        let neighbor = dataArr[1];

       if (map.has(name)){
           map.get(name).push(neighbor);
       }
    }

    let sorted = Array.from(map.entries()).sort((a, b) => b[1].length - a[1].length);

    for (const neighbor of sorted) {
        console.log(`${neighbor[0]}: ${neighbor[1].length}`);
        for (const name of neighbor[1]) {
            console.log(`--${name}`);
        }
    }
}

neighborhood(['Abbey Street, Herald Street, Bright Mews',
'Bright Mews - Garry',
'Bright Mews - Andrea',
'Invalid Street - Tommy',
'Abbey Street - Billy']);
