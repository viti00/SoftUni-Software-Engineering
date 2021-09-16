function cake(input){

    let width = Number(input.shift());
    let lenght = Number(input.shift());

    let totalCake = width * lenght;
    let totalGetPieces = 0;

        let command = input.shift();

    while(command != "Stop"){
        let piecesCount = Number(command);

        totalGetPieces += piecesCount;

        if (totalGetPieces > totalCake){
            let need = totalGetPieces - totalCake;
            console.log(`No more cake left! You need ${need} pieces more.`);
            break;
        }

        command = input.shift();
    }


    if(totalCake >= totalGetPieces ){
        let left = totalCake - totalGetPieces;
        console.log(`${left} pieces are left.`);
    }
}

cake(["10", "10", "20", "20", "20", "20", "21"]);