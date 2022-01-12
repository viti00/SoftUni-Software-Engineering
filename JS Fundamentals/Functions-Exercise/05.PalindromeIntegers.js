function palindrome(arr){
    debugger;
    for (let i = 0; i < arr.length; i++) {
        let currNum = arr[i];

        if (check(currNum) == true){
            console.log('true');
        }
        else {
            console.log('false')
        }
    }

    function check(currNum){
        let string = currNum.toString();

        let reversed = reverser(string);

        if (reversed == string){
            return true;
        }
        else{
            return false;
        }
    }

    function reverser(string){
        let reversed = string.split("").reverse().join("");
        return reversed;
    }
}

palindrome([123,323,421,121]);