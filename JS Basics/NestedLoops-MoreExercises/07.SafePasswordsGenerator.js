function safePassword(input){
    debugger;
    let firstSymbolEndIndex = Number(input.shift());
    let secondSymbolEndIndex = Number(input.shift());
    let maximumPasswordCount = Number(input.shift());
    let result = "";
    let maxValueForA = 0;
    let maxValueForB = 0;

    for (let A = 35; A <= 55; A++) {
        if (maxValueForA == firstSymbolEndIndex && maxValueForB == secondSymbolEndIndex){
            break;
        }
        if (maximumPasswordCount <= 0){
            break;
        }
        for (let B = 64; B <= 96; B++) {
            if (maxValueForA == firstSymbolEndIndex && maxValueForB == secondSymbolEndIndex){
                break;
            }
            if (maximumPasswordCount <= 0){
                break;
            }
            for (let x = 1; x <= firstSymbolEndIndex; x++) {
                if (maximumPasswordCount <= 0){
                    break;
                }
                if (maxValueForA == firstSymbolEndIndex && maxValueForB == secondSymbolEndIndex){
                    break;
                }
                maxValueForA++;
                maxValueForB = 0;
                for (let y = 1; y <= secondSymbolEndIndex; y++) {
                    maxValueForB++;
                    if (maximumPasswordCount > 0){
                        result += `${String.fromCharCode(A)}${String.fromCharCode(B)}${x}${y}${String.fromCharCode(B)}${String.fromCharCode(A)}` + "|";
                        maximumPasswordCount--;
                        A++;
                        B++;
                        if (A > 55){
                            A = 35;
                        }
                        if (B > 96){
                            B = 64;
                        }
                    }
                    else {
                        break;
                    }
                    if (maxValueForA == firstSymbolEndIndex && maxValueForB == secondSymbolEndIndex){
                        break;
                    }
                    
                }
                
            }
            
        }
    }
    console.log(result);
}
safePassword(["2", "3", "10"]);