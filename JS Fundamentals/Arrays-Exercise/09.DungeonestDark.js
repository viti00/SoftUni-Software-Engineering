function dungeonestDark(arr) {
    debugger;
    let newArr = arr.toString().split("|");
    let hp = 100;
    let coins = 0;
    let roomCounter = 0;

    for (let i = 0; i < newArr.length; i++) {
        let roomArr = newArr[i].split(" ");

        let room = roomArr[0];
        let num = Number(roomArr[1]);

        switch (room) {
            case "potion":
                roomCounter++;
                let healedHp = 0;
                if (hp + num >= 100) {
                    healedHp = 100 - hp;
                    hp = 100;
                    
                }
                else {
                    healedHp = num;
                    hp += num;
                }
                console.log(`You healed for ${healedHp} hp.`);
                console.log(`Current health: ${hp} hp.`);
                break;
            case "chest":
                coins += num;
                roomCounter++;
                console.log(`You found ${num} coins.`);
                break;
            default:
                roomCounter++;
                if (hp > num) {
                    hp -= num;
                    console.log(`You slayed ${room}.`)
                }
                else {
                    hp = 0;
                    console.log(`You died! Killed by ${room}.`);
                    console.log(`Best room: ${roomCounter}`);
                }
                break;
        }

        if (hp <= 0){
            break;
        }
    }

    if (hp > 0){
        console.log(`You've made it!`);
        console.log(`Coins: ${coins}`);
        console.log(`Health: ${hp}`);
    }
}

dungeonestDark(["rat 10|bat 20|potion 10|rat 10|chest 100|boss 70|chest 1000"]);