function solve(arr, delimiter){
    let result = '';

    for (let i = 0; i < arr.length - 1; i++) {
        result += `${arr[i]}${delimiter}`;
    }

    result  += `${arr[arr.length - 1]}`;

    console.log(result);
}

solve(['One', 
'Two', 
'Three', 
'Four', 
'Five'], 
'-'
)