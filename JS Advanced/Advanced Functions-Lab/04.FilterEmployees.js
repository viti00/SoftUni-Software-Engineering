function solve(input, filter){
    debugger;
    let objArr = JSON.parse(input);
    let counter = 0;

    if(filter === 'all'){
        for (const obj of objArr) {
            console.log(print(obj));
            counter++;
        }
        return;
    }

    let criteria = filter.split('-');

    objArr = objArr.filter(x => x[criteria[0]] === criteria[1]);

    for (const obj of objArr) {
        console.log(print(obj));
        counter++;
    }

    function print(obj){

        return `${counter}. ${obj['first_name']} ${obj['last_name']} - ${obj['email']}`;
    }
}


solve(`[{
    "id": "1",
    "first_name": "Ardine",
    "last_name": "Bassam",
    "email": "abassam0@cnn.com",
    "gender": "Female"
  }, {
    "id": "2",
    "first_name": "Kizzee",
    "last_name": "Jost",
    "email": "kjost1@forbes.com",
    "gender": "Female"
  },  
{
    "id": "3",
    "first_name": "Evanne",
    "last_name": "Maldin",
    "email": "emaldin2@hostgator.com",
    "gender": "Male"
  }]`, 
'gender-Female'
)