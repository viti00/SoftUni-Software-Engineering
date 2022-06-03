function solve(input){
    debugger;
    let maxNumber = 0;
   for (let i = 0; i < input.length; i++) {
       for (let j = 0; j < input[i].length; j++) {
           if(input[i][j] > maxNumber){
               maxNumber = input[i] [j];
           }
       }
   }

   return maxNumber
}

console.log(solve([[20, 50, 10],
    [8, 33, 145]]
   ));