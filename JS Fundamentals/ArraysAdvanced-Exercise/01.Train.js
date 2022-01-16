function train(arr){
    let wagons = arr.shift().split(" ").map(Number);
    let maxCapacity = Number(arr.shift());
    
    for (let i = 0; i < arr.length; i++) {
        let commands = arr[i].split(" ");

        let command = commands.shift();

        if (command == "Add"){
            let number = Number(commands.shift());
            addElement(number);
        }
        else {
            let num = Number(command);
            findFreeSpots(num, maxCapacity);
        }


        function addElement(number){
            wagons.push(number);
        }

        function findFreeSpots(num, maxCapacity){
            for (let i = 0; i < wagons.length; i++) {
                let currWagon = wagons[i];

                if(currWagon + num <= maxCapacity){
                    currWagon += num;
                    wagons[i] = currWagon;
                    break;
                }
            }
        }

    }

    console.log(wagons.join(" "));
}

train(['32 54 21 12 4 0 23',
'75',
'Add 10',
'Add 0',
'30',
'10',
'75']
);