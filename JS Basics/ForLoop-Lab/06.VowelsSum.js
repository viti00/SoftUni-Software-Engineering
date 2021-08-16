function vowelsSum(input){
    let text = input[0];

    let vowelA = 1;
    let vowelE = 2;
    let vowelI = 3;
    let vowelO = 4;
    let vowelU = 5;

    let sum = 0.0;

    for (let index = 0; index < text.length; index++) {
        if(text[index] == "a"){
            sum += vowelA;
        }
        else if (text[index] == "e"){
            sum += vowelE;
        }
        else if (text[index] == "i"){
            sum += vowelI;
        }
        else if (text[index] == "o"){
            sum += vowelO;
        }
        else if (text[index] == "u"){
            sum += vowelU;
        }
        
    }

    console.log(sum);
}

vowelsSum(["hello"]);