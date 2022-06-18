function solve(...input){
    debugger;
    let arr = [];
    let typeCounts = {};

    for (const argument of input) {
        arr.push(typeof(argument));
        arr.push(argument);

        if(!typeCounts.hasOwnProperty(typeof(argument))){
            typeCounts[typeof(argument)] = 1;
        }
        else {
            typeCounts[typeof(argument)]++;
        }
    }
    
   for (let i = 0; i < arr.length; i+=2) {
       console.log(`${arr[i]}: ${arr[i + 1]}`);
   }
    let sorted = Object.fromEntries(Object.entries(typeCounts).sort(([,a],[,b]) => b - a));
    for (const key in sorted) {
        console.log(`${key} = ${sorted[key]}`)
    }
    
}

//solve('cat', 42, function () { console.log('Hello world!'); });

solve({ name: 'bob'}, 3.333, 9.999);