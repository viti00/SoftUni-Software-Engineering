function moving(input){

    let width = Number(input.shift());
    let lenght = Number(input.shift());
    let hight = Number(input.shift());

    let i = 0;
    let command = input.shift();
    let apartmentSize = width * lenght * hight;

    while(command != "Done"){
        let boxCount = Number(command);

        apartmentSize -= boxCount;

        if (apartmentSize <= 0){
            console.log(`No more free space! You need ${Math.abs(apartmentSize)} Cubic meters more.`);
            break;
        }
        command = input[i];
        i++;

    }

    if(apartmentSize > 0){
        console.log(`${apartmentSize} Cubic meters left.`);
    }
}

moving(["10", "1" , "2", "4", "6", "Done"]);