function stringSubstring(word, text){
    let arr = text.split(" ");
    let neededWord = "";

    for (const w of arr) {
        if(w.toLowerCase() == (word.toLowerCase())){
            console.log(word);
            neededWord = word;
            break;
        }
        
    }
    if (neededWord != word ){
        console.log(`${word} not found!`);
    }
}

stringSubstring('python',
'JavaScript is the best programming language');