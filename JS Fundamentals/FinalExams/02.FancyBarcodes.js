function fancyBarcode(arr){
    debugger;
    let n = Number(arr.shift());
    let regex = /^(@#+)(?<name>[A-Z][A-Za-z0-9]{4,}[A-Z])\1$/;
    let digitRegex = /\d/g;
    for (let i = 1; i <= n; i++) {
        if ((validBarcode = regex.exec(arr.shift())) != null){
            let name = validBarcode.groups['name'];
            getProductGroup(name, digitRegex);
        }
        else {
            console.log(`Invalid barcode`);
        }

    }

    function getProductGroup(name, digitRegex){
        let result = "";
        let matches = name.match(digitRegex);
        if (matches != null){
            for (let i = 0; i < matches.length; i++) {
                result += matches[i];
            }
        }
        else {
            result = "00"
        }

        console.log(`Product group: ${result}`);
    }
}

fancyBarcode((["3",
"@#FreshFisH@#",
"@###Brea0D@###",
"@##Che4s6E@##"]));