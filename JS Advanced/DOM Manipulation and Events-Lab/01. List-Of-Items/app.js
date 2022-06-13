function addItem() {
    let listLiElements = document.getElementById("items");

    let newElement = document.createElement('li');
    newElement.textContent = document.getElementById('newItemText').value;

    listLiElements.appendChild(newElement);
}