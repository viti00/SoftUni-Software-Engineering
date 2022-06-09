function extract(content) {
    let textElement = document.getElementById(content);
    let textValue = textElement.textContent;
    let position = 0;
    let wordArr = [];
    while(true){
        let start = textValue.indexOf('(', position);
        if(start < 0){
            break;
        }

        let word = textValue.slice(start + 1, textValue.indexOf(')', position));

        position = textValue.indexOf(')', position) + 1;
        wordArr.push(word);
    }

    return wordArr.join('; ')
}