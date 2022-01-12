function passwordValidator(input) {
    let password = input;
    let digitCount = 0;
    debugger;
    if (checkLength(password) == true && checkPassword(password) == true && digitCount >= 2) {
        console.log(`Password is valid`);
    }
    else {
        if (checkLength(password) == false) {
            console.log(`Password must be between 6 and 10 characters`);
        }
        if (checkPassword(password) == false) {
            console.log(`Password must consist only of letters and digits`);
        }
        if (digitCount < 2) {
            console.log(`Password must have at least 2 digits`);
        }
    }



    function checkLength(password) {
        if (password.length >= 6 && password.length <= 10) {
            return true;
        }
        return false;
    }

    function isOnlyLettersAndDigits(currChar) {
        let code = currChar.charCodeAt(0);
        if (code >= 65 && code <= 90 || code >= 97 && code <= 122) {
            return true;
        }
        else if (code >= 48 && code <= 57){
            digitCount++;
            return true;
        }
        return false;
    }

    function checkPassword(password) {
        for (let i = 0; i < password.length; i++) {
            let currChar = password[i];
            if (isOnlyLettersAndDigits(currChar) == false) {
                return false;
            }
        }
        return true;
    }
}

passwordValidator("logIn")