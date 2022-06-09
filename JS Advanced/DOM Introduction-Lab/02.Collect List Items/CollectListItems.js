function extractText() {
    let listElements = document.querySelectorAll('#items li');
    
    let textAreaElement = document.getElementById('result');

    for (const element of listElements) {
        textAreaElement.value += element.textContent + '\n'
    };
}