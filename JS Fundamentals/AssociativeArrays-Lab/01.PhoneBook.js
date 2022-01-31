function phoneBook(arr){
    debugger;
    let contacts = {};
    for (const data of arr) {
        let dataArr = data.split(" ");
        let name = dataArr[0];
        let number = dataArr[1];

        contacts[name] = number;
    }


    for (const key in contacts) {
        console.log(`${key} -> ${contacts[key]}`);
    }
}

phoneBook(['Tim 0834212554',
'Peter 0877547887',
'Bill 0896543112',
'Tim 0876566344']);