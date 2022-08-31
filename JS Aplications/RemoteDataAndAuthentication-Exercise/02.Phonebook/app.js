function attachEvents() {
    let baseUrl = 'http://localhost:3030/jsonstore/phonebook';
    let ulElement = document.getElementById('phonebook');
    let loadBtn = document.getElementById('btnLoad');
    let createBtn = document.getElementById('btnCreate');


    loadBtn.addEventListener('click', loadContacts);
    createBtn.addEventListener('click', createContact);
    
    async function createContact(){
        let personElement = document.getElementById('person');
        let phoneElement = document.getElementById('phone');

        await fetch(baseUrl, {
            method: 'post',
            headers: {
                'Content-Type' : 'aplication/json'
            },
            body: JSON.stringify({
                person: personElement.value,
                phone: phoneElement.value
            })
        })

        personElement.value = '';
        phoneElement.value = '';
        loadContacts();
            
    }

    async function loadContacts(){
        ulElement.innerHTML = '';
       
        await fetch(baseUrl)
            .then(res=> res.json())
            .then(contacts => {
                for (const key in contacts) {
                    let{person, phone} = contacts[key];

                    let liElement = document.createElement('li');
                    liElement.textContent = `${person}: ${phone}`;

                    let deleteBtn = document.createElement('button');
                    deleteBtn.textContent = 'Delete';

                    deleteBtn.addEventListener('click', deleteContact);

                    liElement.appendChild(deleteBtn);

                    ulElement.appendChild(liElement);
                }                
            })
    }

    async function deleteContact(e){
        debugger;
        let data = e.target.parentNode.textContent.split(': ');
        let currPerson = data[0];
        let currPhone = data[1].substring(0, data[1].indexOf('D'));

        fetch(`${baseUrl}`)
            .then(res=> res.json())
            .then(contacts => {
                let contactKey = '';
                for (const key in contacts) {
                    let {person, phone} = contacts[key];

                    if(currPerson == person && currPhone == phone){
                        contactKey = key;
                        break;
                    }
                }

                return fetch(`${baseUrl}/${contactKey}`, {
                    method: 'delete'
                })
            })
            .then(res=> res.json())
            .then(contact => {
                loadContacts();
            })
            
    }
}

attachEvents();