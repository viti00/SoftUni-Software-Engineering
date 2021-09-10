function football(input){
    let capacity = Number(input.shift());
    let fans = Number(input.shift());

    let sectorACount = 0;
    let sectorBCount = 0;
    let sectorVCount = 0;
    let sectorGCount = 0;

    for (let index = 0; index < fans; index++) {
        let sector = input[index];
        switch(sector){
            case"A":
                sectorACount++;
            break;
            case"B":
                sectorBCount++;
            break;
            case"V":
                sectorVCount++;
            break;
            case"G":
                sectorGCount++;
            break;
        }
        
    }

    let sectorAPercent = sectorACount / fans * 100;
    let sectorBPercent = sectorBCount / fans * 100;
    let sectorVPercent = sectorVCount / fans * 100;
    let sectorGPercent = sectorGCount / fans * 100;

    let total = fans / capacity * 100;


    console.log(`${sectorAPercent.toFixed(2)}%`);
    console.log(`${sectorBPercent.toFixed(2)}%`);
    console.log(`${sectorVPercent.toFixed(2)}%`);
    console.log(`${sectorGPercent.toFixed(2)}%`);
    console.log(`${total.toFixed(2)}%`);
}

football(["76", "10", "A", "V","V","V","G", "B","A", "V", "B", "B"]);