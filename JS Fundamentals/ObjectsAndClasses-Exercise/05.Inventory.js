function inventory(arr){
    let heroes = [];
    class Hero{
        constructor(name, level, items){
            this.name = name;
            this.level = Number(level);
            this.items = items;
        }
    }

    for (let i = 0; i < arr.length; i++) {
        let curr = arr[i].split(" / ");
        let name = curr.shift();
        let level = Number(curr.shift());

        let items = curr.shift().split(", ");

        heroes.push(new Hero(name, level, items));
    }


    for (const hero of heroes.sort((a, b) => a.level - b.level)) {
        console.log(`Hero: ${hero.name}`);
        console.log(`level => ${hero.level}`);
        console.log(`items => ${hero.items.sort().join(", ")}`);
    }

}

inventory([
    "Isacc / 25 / Apple, GravityGun",
    "Derek / 12 / BarrelVest, DestructionSword",
    "Hes / 1 / Desolator, Sentinel, Antara"
    ]);