function addressBook(arr){
    debugger;
    let address = {};

    for (const data of arr) {
        let dataArr = data.split(":");

        let name = dataArr[0];
        let addres = dataArr[1];

        address[name] = addres;
    }

    let sorted = Array.from(Object.entries(address))
        .sort();
    for (const addres of sorted) {
        console.log(`${addres[0]} -> ${addres[1]}`);
    }
}

addressBook(['Tim:Doe Crossing',
'Bill:Nelson Place',
'Peter:Carlyle Ave',
'Bill:Ornery Rd']);