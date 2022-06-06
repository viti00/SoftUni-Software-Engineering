function solve(input){
    debugger;
    input=input.map(Number);
    let result=[];
    let biggest = input[0];
    for (let i = 0; i < input.length; i++) {
        if(input[i]>=biggest){
            result.push(input[i]);
            biggest=input[i];
        }
    }
    return (result);
}

console.log(solve([1, 
    3, 
    8, 
    4, 
    10, 
    12, 
    3, 
    2, 
    24]
    ));