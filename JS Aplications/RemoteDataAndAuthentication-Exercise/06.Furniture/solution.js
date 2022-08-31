function solve() {
  let register = document.getElementById("register-form");
  let login = document.getElementById('login-form');
  let divRow = document.getElementsByClassName("row")[0];

  register.addEventListener('submit', registerUser);
  login.addEventListener('submit', loginUser);

  async function registerUser(e){
    e.preventDefault();
    Array.from(divRow.querySelectorAll('div')).forEach((el, i) => {
      i === 1 ? el.remove() : el
    })
    debugger;
    let formData = new FormData(e.target);

    let email = formData.get('email');
    let password = formData.get('password');
    let rePassword = formData.get('rePass');

    try {
        if(email.length > 0 && password.length > 0 && password === rePassword){
            let url = 'http://localhost:3030/users/register';
            let registerResponse = await fetch(url, {
              method: 'post',
              headers: {
                 'Content-Type': 'aplication/json'
              },
              body: JSON.stringify({
                email: email,
                password: password,
              })
            });

            let registerResult = await registerResponse.json();
            localStorage.setItem('token', registerResult.accessToken);
            location.assign('./homeLogged.html')
        }
        else {
            throw new Error;
        }
    } catch (error) {
        let divElement = document.createElement('div');
        divElement.setAttribute('class', 'col-md-12');
        divElement.setAttribute('id', "error");
        
        let pElment = document.createElement('p');
        pElment.textContent = 'Invalid data! Please try again!';
        divElement.appendChild(pElment);

        divRow.appendChild(divElement);
    }
  }

  async function loginUser(e){
    e.preventDefault();
    debugger;
    Array.from(divRow.querySelectorAll('div')).forEach((el, i) => {
      i === 1 ? el.remove() : el
    })
    debugger;
    let formData = new FormData(e.target);

    let email = formData.get('email');
    let password = formData.get('password');

    try {
        if(email.length > 0 && password.length > 0){
            let url = 'http://localhost:3030/users/login';
            let loginResponse = await fetch(url, {
              method: 'post',
              headers: {
                 'Content-Type': 'aplication/json'
              },
              body: JSON.stringify({
                email: email,
                password: password,
              })
            });

            let loginResult = await loginResponse.json();

            if(loginResult.code > 299){
              throw new Error;
            }
            
            localStorage.setItem('token', loginResult.accessToken);
            location.assign('./homeLogged.html')
        }
        else {
            throw new Error;
        }
    } catch (error) {
        let divElement = document.createElement('div');
        divElement.setAttribute('class', 'col-md-12');
        divElement.setAttribute('id', "error");
        
        let pElment = document.createElement('p');
        pElment.textContent = 'Invalid data! Please try again!';
        divElement.appendChild(pElment);

        divRow.appendChild(divElement);
    }

  }

}

solve();