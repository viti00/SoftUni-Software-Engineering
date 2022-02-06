function revealWords(words, text){
    let wordsArr = words.split(", ");
    let textArr = text.split(" ");

    for (let i = 0; i < textArr.length; i++) {
        if(textArr[i].startsWith('*')){
            let replacement = getWord(wordsArr, textArr[i])
            text = text.replace(textArr[i], replacement);
        }
    }

    console.log(text);

    function getWord(wordsArr, currWord){
        for (let i = 0; i < wordsArr.length; i++) {
            if (wordsArr[i].length == currWord.length){
                return wordsArr[i];
            }
        }
    }
}

revealWords('great',
'softuni is ***** place for learning new programming languages');