function muOnline(arr){
    arr = arr.split("|");
    let initialHealth = 100;
    let initialBitcoins = 0; 
    let roomCount = 0;

    for (let i = 0; i < arr.length; i++) {
        let curr = arr[i].split(" ");
        let room = curr[0];
        let score = Number(curr[1]);
        roomCount++;
        switch(room){
            case"potion":
            let healedHp = 0;
                if (initialHealth + score >= 100){
                    healedHp = 100 - initialHealth;
                    initialHealth = 100;
                }
                else {
                    healedHp = score;
                    initialHealth += score;
                }
                console.log(`You healed for ${healedHp} hp.`);
                console.log(`Current health: ${initialHealth} hp.`);
            break;
            case"chest":
                initialBitcoins += score;
                console.log(`You found ${score} bitcoins.`);
            break;
            default:
                if (initialHealth > score){
                    initialHealth -= score;
                    console.log(`You slayed ${room}.`);
                }
                else {
                    console.log(`You died! Killed by ${room}.`);
                    initialHealth = 0;
                    console.log(`Best room: ${roomCount}`);
                }
                break;
        }
        if (initialHealth <= 0){
            break;
        }
    }
    if (initialHealth > 0){
        console.log(`You've made it!`);
        console.log(`Bitcoins: ${initialBitcoins}`)
        console.log(`Health: ${initialHealth}`);
    }
}

muOnline("rat 10|bat 20|potion 10|rat 10|chest 100|boss 70|chest 1000");