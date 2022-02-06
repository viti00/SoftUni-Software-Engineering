function replaceRepeatingChars(input){
    debugger;
    let manipulatingText = input;
    let currSequence = "";
    for (let i = 0; i < input.length; i++) {
        if (input[i] == input[i + 1]){
            currSequence += input[i];
        }
        else {
            currSequence += input[i];
            manipulatingText  = manipulatingText.replace(currSequence, currSequence[0]);
            currSequence = "";
        }
    }

    console.log(manipulatingText);
}

replaceRepeatingChars('qqqwerqwecccwd');