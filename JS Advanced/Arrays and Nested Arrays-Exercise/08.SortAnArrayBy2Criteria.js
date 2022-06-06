function solve(input){

    let result = input.sort((a,b) => {

        if(a.length > b.length){
            return 1;
        }
        else if(a.length < b.length){
            return - 1;
        }
        else {
            return a.localeCompare(b);
        }
    });

    console.log(result.join('\n'));
}

solve(['Isacc', 
'Theodor', 
'Jack', 
'Harrison', 
'George']
)