function password(input){
    let username = input.shift();
    let password = input.shift();

    let i = 0;

    while(true){
        let currPass = input[i];

        if (password == currPass){
            console.log(`Welcome ${username}!`);
            break;
        }

        i++;
    }
}

password(["Velik", "1234", "pass", "4321", "1234"]);