function emojiDetector(input) {
    debugger;
    let emojiRegex = /(?<emoji>(\*\*|::)([A-Z][a-z]{2,})\2)/g;
    let digitRegex = /\d/g;

    let coolThreshold = 1;

    while ((cool = digitRegex.exec(input)) !== null){
        coolThreshold *= Number(cool);
    }


    let emojies = [];

    while((valid = emojiRegex.exec(input)) != null){
        emojies.push(valid.groups['emoji']);
    }

    console.log(`Cool threshold: ${coolThreshold}`);
    console.log(`${emojies.length} emojis found in the text. The cool ones are:`)

    let coolestEmojies = [];
    for (const emoji of emojies) {
        let points = getThreshold(emoji);

        if(points >= coolThreshold){
            coolestEmojies.push(emoji);
        }
    }

    console.log(coolestEmojies.join("\n"));

    

    function getThreshold(emoji){
        let points = 0;
        for (let i = 2; i < emoji.length - 2; i++) {
            points += emoji[i].charCodeAt(0);
        }

        return points;
    }
}

emojiDetector([("In the Sofia Zoo there are 311 animals in total! ::Smiley:: This includes 3 **Tigers**, 1 ::Elephant:, 12 **Monk3ys**, a **Gorilla::, 5 ::fox:es: and 21 different types of :Snak::Es::. ::Mooning:: **Shy**")]);