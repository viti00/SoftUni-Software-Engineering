function heroes(arr){
    debugger;
    let n = Number(arr.shift());
    let myHeroes = new Map();
    let mana = 0;
    let hp = 0;

    for (let i = 1; i <= n; i++) {
        let curr = arr.shift().split(" ");
        let heroName = curr[0];
        let hp = Number(curr[1]);
        let mp = Number(curr[2]);

        myHeroes.set(heroName, [hp, mp]);
    }

    let command = arr.shift();

    while(command != "End"){
        let curr = command.split(" - ");
        let type = curr[0];
        let name = curr[1];

        switch(type){
            case"CastSpell":
            let mpNeed = Number(curr[2]);
            let spellName = curr[3];

             mana = myHeroes.get(name)[1];
             hp = myHeroes.get(name)[0];

            if (mana >= mpNeed){
                myHeroes.set(name,[hp, mana - mpNeed]);
                console.log(`${name} has successfully cast ${spellName} and now has ${myHeroes.get(name)[1]} MP!"`);
            }
            else {
                console.log(`${name} does not have enough MP to cast ${spellName}!`);
            }
            break;
            case"TakeDamage":
                let dmg = Number(curr[2]);
                let attacker = curr[3];
                mana = myHeroes.get(name)[1];
                hp = myHeroes.get(name)[0];

                myHeroes.set(name, [hp - dmg, mana]);

                if ((health = myHeroes.get(name)[0]) > 0){
                    console.log(`${name} was hit for ${dmg} HP by ${attacker} and now has ${myHeroes.get(name)[0]} HP left!`);
                }
                else{
                    myHeroes.delete(name);
                    console.log(`${name} has been killed by ${attacker}!"`)
                }
            break;
            case"Recharge":
                let mp = Number(curr[2]);
                let recharged = 0;
                hp = myHeroes.get(name)[0];
                if ((myHeroes.get(name)[0] + mp )> 200){
                    recharged = 200 - myHeroes[name][1];
                    myHeroes.set(name, [hp, 200]);
                }
                else {
                    let mana = myHeroes.get(name)[1];
                    myHeroes.set(name, [hp, mana + mp]);
                    recharged = mp;
                    
                }

                console.log(`${name} recharged for ${recharged} MP!`)
            break;
            case"Heal":
                let HP = Number(curr[2]);
                let healed = 0;
                mana = myHeroes.get(name)[1];

                if ((health = myHeroes.get(name)[0]) + HP > 100){
                    healed = 100 - myHeroes.get(name)[0];
                    myHeroes.set(name [100, mana]);
                }
                else {
                    let health = myHeroes.get(name)[0];
                    myHeroes.set(name,[health + HP, mana]) ;
                    healed = HP;
                }

                console.log(`${name} healed for ${healed} HP!`);
            break;
        }

        command = arr.shift();
    }

    let sorted = Array.from(myHeroes.entries()).sort((a, b) => b[1][0] - a[1][0]);

    for (const hero of sorted.sort((a, b) => a[0] - b[0])) {
        console.log(hero[0]);
        console.log(`  HP: ${hero[1][0]}`);
        console.log(`  MP: ${hero[1][1]}`);
    }
}

heroes(["2",
"Solmyr 85 120",
"Kyrre 99 50",
"Heal - Solmyr - 10",
"Recharge - Solmyr - 50",
"TakeDamage - Kyrre - 66 - Orc",
"CastSpell - Kyrre - 15 - ViewEarth",
"End"]);