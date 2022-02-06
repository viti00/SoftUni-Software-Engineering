function hardWord(arr){
    debugger;
    let text = arr.shift();
    let words = arr;

    while(text.includes('_')){
        let index = text.indexOf("_");
        let currWord = "";

        for (let i = index; i < text.length; i++) {
            if (text[i] != "_"){
                break;
            }
            currWord+= text[i];
        }
        let replacement = getCorrectWord(words, currWord);

        text = text.replace(currWord, replacement);

    }

    console.log(text);

    function getCorrectWord(words, currWord){
        for (const word of words) {
            for (const w of word) {
                if(w.length == currWord.length){
                    return w;
                }
            }
        }
    }
}

hardWord(['Hi, grandma! I\'m so ____ to write to you. ______ the winter vacation, so _______ things happened. My dad bought me a sled. Mom started a new job as a __________. My brother\'s ankle is ________, and now it bothers me even more. Every night Mom cooks ___ on your recipe because it is the most delicious. I hope this year Santa will _____ me a robot.',
['pie', 'bring', 'glad', 'During', 'amazing', 'pharmacist', 'sprained']]);
