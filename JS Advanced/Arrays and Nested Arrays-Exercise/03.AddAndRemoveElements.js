function solve(input) {
    let arr = [];
    let currElement = 1;
    debugger;

    for (const cmd of input) {
        if (cmd === 'add') {
            arr.push(currElement);
        }
        else if (cmd === 'remove') {
            arr.pop();
        }
        currElement++;
    }

    if(arr.length === 0){
        console.log('Empty');
        return;
    }
    console.log(arr.join('\n'));
}

solve(['add', 
'add', 
'remove', 
'add', 
'add']

)