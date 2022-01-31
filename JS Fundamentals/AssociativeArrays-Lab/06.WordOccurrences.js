function wordOccurrences(arr){
    let map = new Map();

    for (const word of arr) {
        
        if (!map.has(word)){
            map.set(word, 1);
        }
        else {
            let times = map.get(word);
            times++;
            map.set(word, times);
        }
    }


    let sorted = Array.from(map.entries()).sort((a, b) => b[1] - a[1]);

    for (const occurrences of sorted) {
        console.log(`${occurrences[0]} -> ${occurrences[1]} times`);
    }
}

wordOccurrences(["Here", "is", "the", "first", "sentence", "Here", "is", "another", "sentence", "And", "finally", "the", "third", "sentence"]);