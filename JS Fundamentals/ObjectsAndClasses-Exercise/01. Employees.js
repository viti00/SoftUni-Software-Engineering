function employees(arr){
    debugger;
    
    let employees = [];

    class Employee{
        constructor(name, personalNumber){
            this.name = name;
            this.personalNumber = personalNumber;
        }
    }

    for (let i = 0; i < arr.length; i++) {
       let name = arr[i];
       let personalNumber = arr[i].length;

       employees.push(new Employee(name, personalNumber));
    }

    for (const employee of employees) {
        console.log(`Name: ${employee.name} -- Personal Number: ${employee.personalNumber}`);
    }
}

employees([
    'Silas Butler',
    'Adnaan Buckley',
    'Juan Peterson',
    'Brendan Villarreal'
    ]
    );