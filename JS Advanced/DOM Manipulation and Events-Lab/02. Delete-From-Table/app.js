function deleteByEmail() {
    let elementToDelete = document.getElementsByName('email')[0].value;
    let colElements = Array.from(document.querySelectorAll('tbody tr'));

    let resultElement = document.getElementById('result');

    for (const col of colElements) {
        let email = col.children[1];

        if(email.textContent === elementToDelete){
            col.remove();
            resultElement.textContent = 'Deleted.';
            return;
        }
    }

    resultElement.textContent = 'Not found.';
}