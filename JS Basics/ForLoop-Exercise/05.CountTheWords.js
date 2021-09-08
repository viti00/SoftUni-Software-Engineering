function wordsCount(input){
    let text = input[0].split(" ");
    let count = 0;

    for (let index = 0; index < text.length; index++) {
        count++;
    }
    
    if (count > 10){
        console.log(`The message is too long to be send! Has ${count} words.`)
    }
    else{
        console.log("The message was sent successfully!");
    }
}

wordsCount(["This message has exactly eleven words. One more as it's allowed!"]);