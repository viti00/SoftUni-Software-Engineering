let divUserElement = document.getElementById('user');
divUserElement.style.display = 'none';

let registerForm = document.getElementById('register-form');

let section =document.getElementById('register-view');


registerForm.addEventListener('submit', register)

async function register(e){
    e.preventDefault();
    debugger;
    if(section.querySelector('div')){
        section.children[2].remove();
    }

    let formData = new FormData(e.target);

    let email = formData.get('email');
    let password = formData.get('password');
    let rePassword = formData.get('rePass');

    try {
        if(email.length > 0 && password.length > 0 && password === rePassword){
            let response = await fetch("http://localhost:3030/users/register", {
                method: 'post',
                headers:{
                    'Content-Type': 'aplication/json'
                },
                body: JSON.stringify({
                    email: email,
                    password: password
                })
            })
            let result = await response.json();
            localStorage.setItem('token', result.accessToken);
            location.assign("./homeLogged.html");
        }
        else {
            throw new Error;
        }
    } catch (error) {
        let divElement = document.createElement('div');
        let pElment = document.createElement('p');
        pElment.textContent = 'Invalid data! Please try again!';
        divElement.appendChild(pElment);
        section.appendChild(divElement);
    }
}