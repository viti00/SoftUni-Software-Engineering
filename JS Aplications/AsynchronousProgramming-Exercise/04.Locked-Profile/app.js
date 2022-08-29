function lockedProfile() {
    let baseUrl = 'http://localhost:3030/jsonstore/advanced/profiles';
    let divMainElement = document.getElementById('main');
    divMainElement.innerHTML = '';

    fetch(baseUrl)
        .then(function (response) {
            return response.json();
        })
        .then(function (characters) {
            let counter = 1;
            for (const key in characters) {
                let { username, email, age } = characters[key];

                let divProfileElement = createProfile(username, email, age, counter);

                divMainElement.appendChild(divProfileElement);

                counter++;
            }
        })
        .catch(function (error) {

        })

    function createProfile(username, email, age, counter) {


        let divProfileElement = document.createElement('div');
        divProfileElement.setAttribute('class', 'profile');

        let imgElement = document.createElement('img');
        imgElement.setAttribute("src", './iconProfile2.png');
        imgElement.setAttribute('class', 'userIcon');

        let labelLockElement = document.createElement('label');
        labelLockElement.textContent = 'Lock'

        let inputLockElement = document.createElement('input');
        inputLockElement.setAttribute("type", "radio");
        inputLockElement.setAttribute("name", `user${counter}locked`);
        inputLockElement.setAttribute('value', 'lock');
        inputLockElement.setAttribute('checked', 'true');

        let labelUnlockElement = document.createElement('label');
        labelUnlockElement.textContent = 'Unlock'

        let inputUnockElement = document.createElement('input');
        inputUnockElement.setAttribute("type", "radio");
        inputUnockElement.setAttribute("name", `user${counter}locked`);
        inputUnockElement.setAttribute('value', 'Unlock');

        let brElement = document.createElement('br');

        let hrElement = document.createElement('hr');

        let labelUsernameElement = document.createElement('label');
        labelUsernameElement.textContent = "Username";

        let usernameInputElement = document.createElement('input');
        usernameInputElement.setAttribute('type', 'text');
        usernameInputElement.setAttribute('name', `user${counter}Username`);
        usernameInputElement.value = username;
        usernameInputElement.setAttribute('style', 'disabled readonly');

        let hiddenDiv = document.createElement("div");
        hiddenDiv.setAttribute('class', 'hiddenInfo');

        let labelEmailElement = document.createElement('label');
        labelEmailElement.textContent = "Email:";

        let emailInputElement = document.createElement('input');
        emailInputElement.setAttribute('type', 'text');
        emailInputElement.setAttribute('name', `user${counter}Email`);
        emailInputElement.value = email;
        emailInputElement.setAttribute('style', 'disabled readonly');


        let labelAgeElement = document.createElement('label');
        labelAgeElement.textContent = "Age:";

        let ageInputElement = document.createElement('input');
        ageInputElement.setAttribute('type', 'text');
        ageInputElement.setAttribute('name', `user${counter}Age`);
        ageInputElement.value = age;
        ageInputElement.setAttribute('style', 'disabled readonly');

        let buttonElement = document.createElement('button');
        buttonElement.textContent = 'Show more'

        hiddenDiv.appendChild(hrElement);
        hiddenDiv.appendChild(labelEmailElement);
        hiddenDiv.appendChild(emailInputElement);
        hiddenDiv.appendChild(labelAgeElement);
        hiddenDiv.appendChild(ageInputElement);

        divProfileElement.appendChild(imgElement);
        divProfileElement.appendChild(labelLockElement);
        divProfileElement.appendChild(inputLockElement);
        divProfileElement.appendChild(labelUnlockElement);
        divProfileElement.appendChild(inputUnockElement);
        divProfileElement.appendChild(brElement);
        divProfileElement.appendChild(hrElement);
        divProfileElement.appendChild(labelUsernameElement);
        divProfileElement.appendChild(usernameInputElement);
        divProfileElement.appendChild(hiddenDiv);
        divProfileElement.appendChild(buttonElement);

        buttonElement.addEventListener('click', showHideFunction);

        return divProfileElement;
    }

    function showHideFunction(e){
        let lockElement = e.target.parentNode.children[2];
        let buttonElement = e.target.parentNode.children[10];

        if(buttonElement.textContent == "Show more"){
            if(lockElement.checked == false){
                let divElement = e.target.parentNode.children[9];
               
                divElement.classList.remove("hiddenInfo");
                
                buttonElement.textContent = 'Hide it';
            }
        }
        else if (buttonElement.textContent == "Hide it"){
            if(lockElement.checked == false){
                let divElement = e.target.parentNode.children[9];
               
                divElement.classList.add("hiddenInfo");

                buttonElement.textContent = 'Show more';
            }
        }
    }
}