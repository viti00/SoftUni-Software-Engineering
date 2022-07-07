function Person(fName, lName){
    this.firstName = fName;
    this.lastName = lName;

    Object.defineProperty(this, 'fullName', {
        get: function() {
            return `${this.firstName} ${this.lastName}`;
        },
        set: function (value){
            let regex = /(?<firstName>\w+) (?<lastName>\w+)/;
            let match = regex.exec(value);
            if(match){
                this.firstName = match.groups.firstName;
                this.lastName = match.groups.lastName;
            }
        }
    });
}
debugger;
let person = new Person("Peter", "Ivanov");
console.log(person.fullName); //Peter Ivanov
person.firstName = "George";
console.log(person.fullName); //George Ivanov
person.lastName = "Peterson";
console.log(person.fullName); //George Peterson
person.fullName = "Nikola Tesla";
console.log(person.firstName); //Nikola
console.log(person.lastName); //Tesla
