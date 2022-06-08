function solve(){
    let obj = {
        mage(name){
            let mage = {
                'name': name,
                'health': 100,
                'mana': 100,
                cast(spellName){
                    this.mana--;
                    console.log(`${this.name} cast ${spellName}`);
                }
            }
            return mage;
        },
        fighter(name){
            let fighter= {
                'name': name,
                'health': 100,
                'stamina': 100,
                fight(){
                    this.stamina--;
                    console.log(`${this.name} slashes at the foe!`);
                }
                
            }
            return fighter;
        }
    }
    return obj;
}

let create = solve();
const scorcher = create.mage("Scorcher");
scorcher.cast("fireball")
scorcher.cast("thunder")
scorcher.cast("light")

const scorcher2 = create.fighter("Scorcher 2");
scorcher2.fight()

console.log(scorcher2.stamina);
console.log(scorcher.mana);
