function sequence(input){
    let n =Number(input[0]);
    let currNum = 1;
    while(currNum <= n){
        console.log(currNum);

        currNum = 2 * currNum + 1;
    }
}

sequence(["17"]);