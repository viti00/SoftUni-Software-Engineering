function addItem() {
    let newItemText = document.getElementById('newItemText');

    let newItemValue = document.getElementById('newItemValue');

    let newElement = document.createElement('option');

    newElement.setAttribute('value', newItemValue.value);

    newElement.textContent = newItemText.value;

    let menuElement = document.getElementById('menu');

    menuElement.appendChild(newElement);

    newItemText.value = '';
    newItemValue.value = '';
}