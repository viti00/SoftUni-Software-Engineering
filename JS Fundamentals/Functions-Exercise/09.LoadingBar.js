function logadingBar(arg) {
    let n = Number(arg);

    if (n == 100) {
        console.log(`${n}% Complete!`);
        console.log(`[%%%%%%%%%%]`);
    }
    else {
        let percentSymbols = n / 10;
        let result = fillResult(n, percentSymbols);

        
        console.log(result);
        console.log("Still loading...");
    }

    function fillResult(n, percentSymbols) {

        let result = `${n}% [`;
        for (let i = 1; i <= percentSymbols; i++) {
            result += '%';
        }
        for (let j = percentSymbols + 1; j <= 10; j++) {
            result += '.';
        }
        result += ']';

        return result;
    }
}

logadingBar("100");