function countStringOccurences(text, searchingWord){
    let arr = text.split(" ");
    let counter = 0;
    for (const word of arr) {
        if (word == searchingWord){
            counter++;
        }
    }

    console.log(counter);
}

countStringOccurences("This is a word and it also is a sentence",
"is");