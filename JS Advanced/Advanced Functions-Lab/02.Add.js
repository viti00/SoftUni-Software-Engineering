function solution(number){
    debugger;
    let num = number;
    return function(number){
        return num + number;
    }
}

let add5 = solution(5);
console.log(add5(2));
console.log(add5(3));
