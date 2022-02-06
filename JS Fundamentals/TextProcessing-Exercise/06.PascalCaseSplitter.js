function PascalSpliter(input) {
    let arr = [];
    let startIndex = 0
    debugger;
    for (let i = 1; i < input.length; i++) {
        
        if(input[i] >= "A" && input[i] <= "Z"){
           let endIndex = i;
           arr.push(input.substr(startIndex, endIndex - startIndex));
           startIndex = i;
        }

        
    }
    arr.push(input.substr(startIndex))
    

    console.log(arr.join(", "));
}

PascalSpliter('HoldTheDoor');