function matchPhone(input){
    let regex = /\+359([ -])2{1}\1\d{3}\1\d{4}\b/g;

    let validPhones = [];

    while((validPhone = regex.exec(input))!= null){

        validPhones.push(validPhone[0]);
    }

    console.log(validPhones.join(", "));
}

matchPhone("+359 2 222 2222,359-2-222-2222, +359/2/222/2222, +359-2 222 2222 +359 2-222-2222, +359-2-222-222, +359-2-222-22222 +359-2-222-2222"
);