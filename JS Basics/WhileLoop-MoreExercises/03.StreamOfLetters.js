function streamOfLetters(input){
    debugger;
    let letter = input.shift();
    let secretComand = "";
    let word = "";
    let newWord = "";
    while(letter != "End"){
        let currChar = letter;

        if ((currChar >= "A" && currChar <= "Z") || currChar >= "a" && currChar <= "z"){
            if (currChar == "c" && !(secretComand.includes("c"))){
                secretComand += currChar;
            }
            else if (currChar == "o" && !(secretComand.includes("o"))){
                secretComand += currChar;

            }
            else if (currChar == "n" && !(secretComand.includes("n"))){
                secretComand += currChar;
            }
            else {
                word += currChar;
            }

            if (secretComand.includes("c")&& secretComand.includes("o") && secretComand.includes("n")){
                word += " ";
                newWord = word;
                secretComand = "";
            }
        }

        letter = input.shift();

    }

    console.log(newWord);
}

streamOfLetters(["h", "n", "e", "l", "l", "o", "o", "c", "t", "c", "h", "o", "e", "r", "e", "n", "e", "End"]);