function passwordReset(arr) {
    debugger;
    let currPassword = arr.shift();

    let command = arr.shift();

    while (command != "Done") {
        let currCmd = command.split(" ");
        let cmd = currCmd[0];

        switch (cmd) {
            case "TakeOdd":
                let result = "";
                for (let i = 0; i < currPassword.length; i++) {
                    if (i % 2 == 1) {
                        result += currPassword[i];
                    }
                }
                currPassword = result;
                console.log(currPassword);
                break;
            case "Cut":
                let start = Number(currCmd[1]);
                let length = Number(currCmd[2]);

                let part = currPassword.slice(start, start + length);
                currPassword = currPassword.replace(part, "");

                console.log(currPassword);
                break;
            case "Substitute":
                let substring = currCmd[1];
                let substitute = currCmd[2];
                if (currPassword.includes(substring)) {
                    while (currPassword.includes(substring)) {
                        currPassword = currPassword.replace(substring, substitute);
                    }
                    console.log(currPassword);
                }
                else {
                    console.log('Nothing to replace!');
                }

                break;
        }
        command = arr.shift();
    }

    console.log(`Your password is: ${currPassword}`);
}

passwordReset((["up8rgoyg3r1atmlmpiunagt!-irs7!1fgulnnnqy",
"TakeOdd",
"Cut 18 2",
"Substitute ! ***",
"Substitute ? .!.",
"Done"]));