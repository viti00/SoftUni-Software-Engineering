function passwordGenerator(arr) {
    let firstString = arr.shift();
    let secondString = arr.shift();
    let thirdString = arr.shift().toUpperCase();

    debugger;
    let iteratedString = firstString.concat(secondString);
    let counter = 0;
    for (let i = 0; i < iteratedString.length; i++) {
        if (iteratedString[i] == "i" || iteratedString[i] == "e" || iteratedString[i] == "a" || iteratedString[i] == "o" || iteratedString[i] == "u") {
            if (counter >= thirdString.length) {
                counter = 0;
            }
            iteratedString = iteratedString.replace(iteratedString[i], thirdString[counter]);
            counter++;
        }
    }
   
    let result = "";
    for (let j = iteratedString.length - 1; j >= 0; j--) {

        result += iteratedString[j];
    }

    console.log(`Your generated password is ${result}`);
}

passwordGenerator([
    "areyousureaboutthisone",
    "notquitebutitrustyou",
    "disturbed"
]);