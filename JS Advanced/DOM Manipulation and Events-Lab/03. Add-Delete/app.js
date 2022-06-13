function addItem() {
    let listLiElements = document.getElementById('items');

    let input = document.getElementById('newItemText');

    let newLiElement = document.createElement('li');

    newLiElement.textContent = input.value;

    listLiElements.appendChild(newLiElement);

    let newAElement = document.createElement('a');
    newAElement.setAttribute('href', '#');
    newAElement.textContent = '[Delete]';
    newLiElement.appendChild(newAElement);
    
    input.value = '';

    newAElement.addEventListener('click', (e) => {
        e.currentTarget.parentNode.remove();
    })
}