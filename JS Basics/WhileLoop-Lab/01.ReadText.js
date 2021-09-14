function readText(input){
    let text = input.shift();

    let i = 0;

    while(text != "Stop"){
        console.log(text);

        text = input[i];
        i++;
    }
}

readText(["gosho", "Pesho", " ", "damqn", "Stop"]);