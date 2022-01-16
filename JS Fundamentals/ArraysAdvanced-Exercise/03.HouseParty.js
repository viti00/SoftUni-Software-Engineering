function houseParty(arr){

    arr = arr.toString().split(",");
    let guests = [];

    for (let i = 0; i < arr.length; i++) {
        let curr = arr[i].split(" ");

        if (curr.length == 3){
            if (!guests.includes(curr[0])){
                guests.push(curr[0]);
            }
            else{
                console.log(`${curr[0]} is already in the list!`)
            }
        }
        else {
            if(guests.includes(curr[0])){
                guests = guests.filter(x => x !== curr[0]);
            }
            else{
                console.log(`${curr[0]} is not in the list!`);
            }
        }
    }

    console.log(guests.join("\n"));
}

houseParty(['Allie is going!',
'George is going!',
'John is not going!',
'George is not going!']
);