function reversedChars(arg1, arg2, arg3){

    let result = arg1 + arg2 + arg3;
    let reversed = "";
    for (let i = result.length - 1; i >= 0; i--) {
        reversed += result[i] + " ";
    }

    console.log(reversed);
}

reversedChars("a", "b", "c");