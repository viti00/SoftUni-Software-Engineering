function calc() {
    let num1Element = document.getElementById('num1');
    
    let num2Element = document.getElementById('num2');

    let num1Value = num1Element.value;

    let num2Value = num2Element.value;

    let sumElement = document.getElementById('sum');

    sumElement.value = Number(num1Value) + Number(num2Value);
}
