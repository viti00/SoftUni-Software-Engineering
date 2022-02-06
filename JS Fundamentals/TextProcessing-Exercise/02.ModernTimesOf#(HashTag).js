function solve(input){
    debugger;
    let arr = input.split(" ");
    let wordArr = [];

    for (const word of arr) {
        if (word.startsWith("#")){
           wordArr.push(word.substr(1));
        }
    }

    for (const word of wordArr) {
        let result ="";
        for (let i = 0; i < word.length; i++) {
            if (word[i] >= "A" && word[i] <= "Z" || word[i] >= "a" && word[i] <= "z"){
                result += word[i];
            }
            else {
                result = "";
                break;
            }
        }
        if (result.length > 0){
            console.log(word);
        }
    }
}

solve('Nowadays everyone uses # to tag a #special word in #socialMedia');