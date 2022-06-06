function solve(input, n){
    for (let i = 0; i < n; i++) {
        let currElement = input.pop();

        input.unshift(currElement);
    }

    console.log(input.join(' '));
}

solve(['Banana', 
'Orange', 
'Coconut', 
'Apple'], 
15
)