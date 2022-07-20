class SummerCamp{
    constructor(organizer, location){
        this.organizer = organizer;
        this.location = location;
        this.priceForTheCamp = {"child": 150, "student": 300, "collegian": 500};
        this.listOfParticipants = []; 
    }

    registerParticipant (name, condition, money){
        if(!this.priceForTheCamp.hasOwnProperty(condition)){
            throw new Error('Unsuccessful registration at the camp.');
        }
         
        if(this.listOfParticipants.find(x=> x.name == name)){
            return `The ${name} is already registered at the camp.`;
        }

        let neededMoney = this.priceForTheCamp[condition];

        if(money < neededMoney){
            return `The money is not enough to pay the stay at the camp.`;
        }

        this.listOfParticipants.push({name: name, condition: condition, power: 100, wins: 0});
        return `The ${name} was successfully registered.`;
    }

    unregisterParticipant (name){
        if((this.listOfParticipants.find(x=> x.name == name)) == undefined){
            throw new Error(`The ${name} is not registered in the camp.`);
        }

        this.listOfParticipants = this.listOfParticipants.filter(x=> x.name !== name);

        return `The ${name} removed successfully.`;
    }

    timeToPlay (typeOfGame, participant1, participant2){

        let firstParticipant = this.listOfParticipants.find(x=> x.name == participant1);
        let secondParticipant = this.listOfParticipants.find(x=> x.name == participant2);

        if(firstParticipant == undefined || (participant2 !== undefined && secondParticipant == undefined)){
            throw new Error('Invalid entered name/s.');
        }

        if(typeOfGame == 'WaterBalloonFights'){
            if(firstParticipant.condition !== secondParticipant.condition){
                throw new Error(`Choose players with equal condition.`);
            }
        }

        if(typeOfGame == 'Battleship'){
            firstParticipant.power += 20;
            return `The ${participant1} successfully completed the game ${typeOfGame}.`;
        }
        else if (typeOfGame == 'WaterBalloonFights'){
            if(firstParticipant.power > secondParticipant.power){
                firstParticipant.wins += 1;
                return `The ${participant1} is winner in the game ${typeOfGame}.`;
            }
            else if (secondParticipant.power > firstParticipant.power){
                secondParticipant.wins += 1;
                return `The ${participant2} is winner in the game ${typeOfGame}.`;
            }
            else {
                return `There is no winner.`;
            }
        }

    }

    toString(){
        let result = [];
        result.push(`${this.organizer} will take ${this.listOfParticipants.length} participants on camping to ${this.location}`);

        let sortedParticipant = this.listOfParticipants.sort((a,b) => b.wins - a.wins);

        for (const participant of sortedParticipant) {
            let {name, condition, power, wins} = participant;

            result.push(`${name} - ${condition} - ${power} - ${wins}`)
        }

        return result.join('\n');
    }
}

debugger;
const summerCamp = new SummerCamp("Jane Austen", "Pancharevo Sofia 1137, Bulgaria");
console.log(summerCamp.registerParticipant("Petar Petarson", "student", 300));
console.log(summerCamp.timeToPlay("Battleship", "Petar Petarson"));
console.log(summerCamp.registerParticipant("Sara Dickinson", "child", 200));
console.log(summerCamp.timeToPlay("WaterBalloonFights", "Petar Petarson", "Sara Dickinson"));
console.log(summerCamp.registerParticipant("Dimitur Kostov", "student", 300));
console.log(summerCamp.timeToPlay("WaterBalloonFights", "Petar Petarson", "Dimitur Kostov"));

console.log(summerCamp.toString());



