let submitBtn = document.getElementById('submit');
let formElement = document.getElementById('form');
let tbodyElement = document.getElementsByTagName('tbody')[0];
let baseUrl = 'http://localhost:3030/jsonstore/collections/students';

submitBtn.addEventListener('click', submit);

async function submit(e){
    e.preventDefault();

    tbodyElement.innerHTML = '';

    let data = new FormData(formElement);

    let firstName = data.get('firstName');

    let lastName = data.get('lastName');

    let facultyNumber = data.get('facultyNumber');

    let grade = data.get('grade');

    formElement.reset();

    if(firstName.length > 0 && lastName.length > 0 && facultyNumber.length > 0 && grade.length > 0){
       await fetch(baseUrl, {
            method: 'post',
            headers: {
                'Content-Type': 'aplication/json'
            },
            body: JSON.stringify({
                firstName: firstName,
                lastName: lastName,
                facultyNumber: facultyNumber,
                grade: Number(grade)
            })
        })
        .catch(err=> {
            let trElement = document.createElement('tr');
            trElement.textContent = 'Error';
            tbodyElement.appendChild(trElement);
        })
        await get();
    }  
}

async function get(){
    await fetch(baseUrl)
        .then(res=> res.json())
        .then(students => {
            for (const key in students) {
                let {firstName, lastName, facultyNumber, grade} = students[key];

                let trElement = document.createElement('tr');

                let tdFirstNameElement = document.createElement('td');
                tdFirstNameElement.textContent = firstName;

                let tdLastNameElement = document.createElement('td');
                tdLastNameElement.textContent = lastName;

                let tdFacultyNumberElement = document.createElement('td');
                tdFacultyNumberElement.textContent = facultyNumber;
                
                let tdGradeElement = document.createElement('td');
                tdGradeElement.textContent = grade;
                
                trElement.appendChild(tdFirstNameElement);
                trElement.appendChild(tdLastNameElement);
                trElement.appendChild(tdFacultyNumberElement);
                trElement.appendChild(tdGradeElement);

                tbodyElement.appendChild(trElement);
            }
        })
        .catch(err=> {
            let trElement = document.createElement('tr');
            trElement.textContent = 'Error';
            tbodyElement.appendChild(trElement);
        })
}