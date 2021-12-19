function challengeTheWedding(input){
    let mansCount = Number(input.shift());
    let womensCount = Number(input.shift());
    let result = "";

    let tablesCount = Number(input.shift());

    for (let man = 1; man <= mansCount; man++) {
        for (let women = 1; women <= womensCount; women++) {
            
            if (tablesCount > 0){
                result += `(${man} <-> ${women})` + " ";
                tablesCount--;
            }
            else {
                break;
            }
            
        }
        if (tablesCount <= 0){
            break;
        }
        
    }

    console.log(result);
}

challengeTheWedding(["2", "2", "6"]);