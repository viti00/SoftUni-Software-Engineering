function concatenate(input){
    let firstName = input[0];
    let lastName = input[1];
    let age = input[2];
    let city = input[3];

    console.log(`You are ${firstName} ${lastName}, a ${age}-years old person from ${city}.`);
}

concatenate(['Velik', 'Charov' , 21, 'Petrich']);