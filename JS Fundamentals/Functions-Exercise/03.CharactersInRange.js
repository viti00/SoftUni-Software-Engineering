function charactresInRange(char1, char2){
    debugger;
    let startIndex = char1.charCodeAt(0);
    let endIndex = char2.charCodeAt(0);
    let result = "";

    if (startIndex < endIndex){
       result = forloop(startIndex, endIndex);
    }
    else if (startIndex > endIndex){
        result = forloop(endIndex, startIndex);
    }

    console.log(result);

    function forloop(startIndex, endIndex){
        let result = "";
        for (let i = startIndex + 1; i < endIndex; i++) {
            result += String.fromCharCode(i) + " ";
        }

        return result;
    }
}

charactresInRange('a', 'd');