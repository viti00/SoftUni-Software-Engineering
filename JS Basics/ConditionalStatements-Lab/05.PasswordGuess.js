function passwordGuess(input){
    let validPassword = "s3cr3t!P@ssw0rd";

    let entrance = input[0];

    if (entrance == validPassword){
        console.log("Welcome");
    }
    else {
        console.log("Wrong password!");
    }
}

passwordGuess(["s3cr3t!P@ssw0rd"]);