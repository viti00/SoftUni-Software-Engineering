function companyUsers(arr){
    let company = {};
    debugger

    for (const data of arr) {
        let dataArr = data.split(" -> ")
        let companyName = dataArr[0];
        let employeeId  = dataArr[1];

        if (!company.hasOwnProperty(companyName)){
            company[companyName] = [];
        }

        if(!company[companyName].includes(employeeId)){
            company[companyName].push(employeeId);
        }
    }

    let sorted = Array.from(Object.entries(company)).sort((a, b) => a[0].localeCompare(b[0]));

    for (const company of sorted) {
        console.log(company[0]);
        for (const employee of company[1]) {
            console.log(`-- ${employee}`);
        }
    }
}

companyUsers([
    'SoftUni -> AA12345',
    'SoftUni -> CC12344',
    'Lenovo -> XX23456',
    'SoftUni -> AA12345',
    'Movement -> DD11111',
    ]);