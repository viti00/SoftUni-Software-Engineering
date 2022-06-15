function solve(input){
    debugger;
    let arr = [];
    

    function func(){
        for (let i = 0; i < input.length; i++) {
            let splitted = input[i].split(' ');
            if(splitted[0] === 'add'){
                arr.push(splitted[1]);
            }
            else if (splitted[0] === 'remove'){
                arr = arr.filter(x=> x !== splitted[1]);
            }
            else if (splitted[0] === 'print'){
                console.log(arr.join(','));
            }
        }
    }

    return func();
}

solve(['add hello', 'add again', 'remove hello', 'add again', 'print'])

