function evenPowersOf2(input){
    let times = Number(input[0]);

    for (let index = 0; index <= times; index++) {
        if(index % 2 == 0){
            let number = Math.pow(2, index);
            console.log(number);
        }
    }

}

evenPowersOf2(["7"]);