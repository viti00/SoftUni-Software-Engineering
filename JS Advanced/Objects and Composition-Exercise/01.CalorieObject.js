function solve(input){
    const obj = {};

    for (let i = 0; i < input.length; i+= 2) {
        obj[input[i]] = Number(input[i + 1]); 
    }

    return obj;
}

console.log(solve(['Yoghurt', '48', 'Rise', '138', 'Apple', '52']));