function validate() {
    let emailElement = document.getElementById('email');

    emailElement.addEventListener('change', (e) => {
        let regex = /^([\w\-.]+)@([a-z]+)(\.[a-z]+)+$/;
        e.target.classList.remove('error');
        if(e.target.value.match(regex) == null){
            e.target.className = 'error';
        }
    })
}