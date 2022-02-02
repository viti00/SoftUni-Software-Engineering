function wordTracker(arr){
    let lookingWords = arr.shift().split(" ");
    debugger;

    let wordsData = {};

    for (const word of lookingWords) {
        wordsData[word] = 0;
    }


    for (let i = 0; i < arr.length; i++) {
        if(wordsData[arr[i]] != null){
            wordsData[arr[i]]++;
        }
    }
    let sorted = Array.from(Object.entries(wordsData)).sort((a, b) => b[1] - a[1]);
    for (const key of sorted) {
        console.log(`${key[0]} - ${key[1]}`);
    }
}

wordTracker([
    'this sentence', 'In','this','sentence','you','have','to','count','the','occurances','of','the'
    ,'words','this','and','sentence','because','this','is','your','task'
    ]);