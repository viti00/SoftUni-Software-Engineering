function oddOccurrences(arr){
    debugger;
    let occurrences = new Map();
    arr = arr.split(" ");

    for (const word of arr) {
        let currWord = word.toLowerCase().toString();
        if (!occurrences.has(currWord)){
            occurrences.set(currWord, 1);
        }
        else {
            let count = occurrences.get(currWord);
            count++;
            occurrences.set(currWord, count);
        }
    }


    let filtered = Array.from(occurrences.entries()).filter(x => x[1] % 2 == 1);

    let result = [];

    for (const el of filtered) {
        result.push(el[0]);
    }

    console.log(result.join(" "));
}

oddOccurrences('Java C# Php PHP Java PhP 3 C# 3 1 5 C#')