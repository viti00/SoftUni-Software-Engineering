function lettersCombination(input){
    debugger;
    let startIndex = input.shift();
    let endIndex = input.shift();
    let i = startIndex.charCodeAt(0);
    let j = endIndex.charCodeAt(0);
    let letterToSkip = input.shift();

    let h = letterToSkip.charCodeAt(0);

    let counter = 0;

    let result = "";

    for (let first = i; first <= j; first++) {

        for (let second = i; second <= j; second++) {
            for (let third = i; third <= j; third++) {
                
                if (first != h && second != h && third != h){
                    result += `${String.fromCharCode(first)}${String.fromCharCode(second)}${String.fromCharCode(third)}` + " ";
                    counter++;
                }
            }
            
        }
        
    }
    result += counter;
    console.log(result);
}

lettersCombination(["f", "k", "h"]);