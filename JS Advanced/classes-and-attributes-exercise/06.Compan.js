class Company{
    constructor(){
        this.department = {};
    }
    addEmployee(name, salary, position, department){
        
        if(Array.from(arguments).some(x => x == undefined || x == null || x == '')){
            throw new Error('Invalid input!');
        }
        if(salary < 0){
            throw new Error('Invalid input!');
        }

        if(!this.department.hasOwnProperty(department)){
            this.department[department] = [];
        }

        this.department[department].push({name, salary, position});

        console.log(`New employee is hired. Name: ${name}. Position: ${position}`);
    }

    bestDepartment(){
        debugger;
        let bestDepartment = '';
        let bestAverageSalary = 0;
        for (const key in this.department) {
            let salary = 0;
            for (const values of this.department[key]) {
                salary += values.salary;
            }
            let averageSalary = salary / this.department[key].length
            if( averageSalary> bestAverageSalary){
                bestAverageSalary = averageSalary;
                bestDepartment = key;
            }
        }

        let result = `Best Department is: ${bestDepartment}` + '\n';
        result += `Average salary: ${bestAverageSalary.toFixed(2)}` + '\n';

        debugger;
        let orderBySalary = this.department[bestDepartment].sort((a,b) => b.salary - a.salary || a.name.localeCompare(b.name));

        for (const values of orderBySalary) {
            result += `${values.name} ${values.salary} ${values.position}` + '\n';
        }

        return result.trimEnd();
    }
}
debugger;
let c = new Company();
c.addEmployee("Stanimir", 2000, "engineer", "Human resources");
c.addEmployee("Pesho", 1500, "electrical engineer", "Construction");
c.addEmployee("Slavi", 500, "dyer", "Construction");
c.addEmployee("Stan", 2000, "architect", "Construction");
c.addEmployee("Stanimir", 1200, "digital marketing manager", "Marketing");
c.addEmployee("Pesho", 1000, "graphical designer", "Marketing");
c.addEmployee("Gosho", 1350, "HR", "Human resources");
console.log(c.bestDepartment());
