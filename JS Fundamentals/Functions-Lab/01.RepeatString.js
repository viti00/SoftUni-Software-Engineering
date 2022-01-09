function repeatString(string, arg1){
    let text = string;
    let n = Number(arg1);

    console.log(repeater(text, n));

    function repeater(text, n){
        let result = "";
        for (let i = 1; i <= n; i++) {
            result += text;
        }

        return result;
    }
}

repeatString("abc", "3");