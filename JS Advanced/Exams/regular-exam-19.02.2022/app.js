function solve() {
    let hireButn = document.getElementById('add-worker');

    hireButn.addEventListener('click', hire);

    function hire(e){
        e.preventDefault();

        let firstNameElement = document.getElementById('fname');
        let lastNameElement = document.getElementById('lname');
        let emailElement = document.getElementById('email');
        let birthElement = document.getElementById('birth');
        let positionElement = document.getElementById('position');
        let salaryElement = document.getElementById('salary');

        let tbodyElement = document.getElementById('tbody');
        let trElement = document.createElement('tr');

        let tdfirstNameElement = document.createElement('td');
        tdfirstNameElement.textContent = firstNameElement.value;

        let tdLastNameElement = document.createElement('td');
        tdLastNameElement.textContent = lastNameElement.value;

        let tdEmailElement = document.createElement('td');
        tdEmailElement.textContent = emailElement.value;

        let tdBirthElement = document.createElement('td');
        tdBirthElement.textContent = birthElement.value;

        let tdPositionElement = document.createElement('td');
        tdPositionElement.textContent = positionElement.value;

        let tdSalaryElement = document.createElement('td');
        tdSalaryElement.textContent = salaryElement.value;

        let buttonsTdElement = document.createElement('td');

        let firedBtn = document.createElement('button');
        firedBtn.setAttribute('class', 'fired');
        firedBtn.textContent = 'Fired';

        let editBtn = document.createElement('button');
        editBtn.setAttribute('class', 'edit');
        editBtn.textContent = 'Edit';

        buttonsTdElement.appendChild(firedBtn);
        buttonsTdElement.appendChild(editBtn);

        trElement.appendChild(tdfirstNameElement);
        trElement.appendChild(tdLastNameElement);
        trElement.appendChild(tdEmailElement);
        trElement.appendChild(tdBirthElement);
        trElement.appendChild(tdPositionElement);
        trElement.appendChild(tdSalaryElement);
        trElement.appendChild(buttonsTdElement);

        if(firstNameElement.value.length > 0 && lastNameElement.value.length > 0 && emailElement.value.length > 0
            && birthElement.value.length > 0 && positionElement.value.length > 0 && salaryElement.value.length > 0){
                tbodyElement.appendChild(trElement);
                debugger;

                firstNameElement.value = '';
                lastNameElement.value = '';
                emailElement.value = '';
                birthElement.value = '';
                positionElement.value = '';
                salaryElement.value = '';

                let sumElement = document.getElementById('sum');
                console.log(sumElement.textContent);

                let currSum = Number(sumElement.textContent);
                currSum += Number(tdSalaryElement.textContent);

                sumElement.textContent = currSum.toFixed(2);


                editBtn.addEventListener('click', edit);
                firedBtn.addEventListener('click', fired);

                function edit(e){
                    let parentElement = e.target.parentNode.parentNode;

                    firstNameElement.value = parentElement.children[0].textContent;
                    lastNameElement.value = parentElement.children[1].textContent;
                    emailElement.value = parentElement.children[2].textContent;
                    birthElement.value = parentElement.children[3].textContent;
                    positionElement.value = parentElement.children[4].textContent;
                    salaryElement.value = parentElement.children[5].textContent;

                    let sum = Number(parentElement.children[5].textContent);

                    let sumAfterRemove = Number(sumElement.textContent) - sum;

                    sumElement.textContent = sumAfterRemove.toFixed(2);

                    parentElement.remove();
                }

                function fired(e){
                    let parent = e.target.parentNode.parentNode;

                    let salary = Number(parent.children[5].textContent);

                    let afterRemove = Number(sumElement.textContent) - salary;

                    sumElement.textContent = afterRemove.toFixed(2);

                    parent.remove();
                }
            }
    }
}
solve()