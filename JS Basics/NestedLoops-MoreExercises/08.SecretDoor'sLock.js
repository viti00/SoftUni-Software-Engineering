function secretDoor(input){
    let x = Number(input.shift());
    let y = Number(input.shift());
    let z = Number(input.shift());


    for (let first = 1; first <= x; first++) {
        for (let second = 1; second <= y; second++) {
           for (let third = 1; third <= z; third++) {
               
               if(first % 2 == 0 && third % 2 == 0){
                   if (second == 2 || second == 3 || second == 5 || second == 7){
                       console.log(`${first} ${second} ${third}`);
                   }
               }
           }
        }
        
    }
}

secretDoor(["3", "5", "5"]);