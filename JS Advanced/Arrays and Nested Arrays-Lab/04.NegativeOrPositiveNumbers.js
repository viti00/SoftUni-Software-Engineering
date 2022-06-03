function solve(input){
    let arr = [];
    input.forEach(x => {
        if(x < 0){
            arr.unshift(x);
        }else {
            arr.push(x);
        }
    });


   console.log(arr.join('\n'))
}

solve([7, -2, 8, 9])