function subtract() {
    debugger;
   let firstNumber = document.getElementById('firstNumber');
   let secondNumber = document.getElementById('secondNumber');

   let firstElementValue = Number(firstNumber.value);
   let secondElementValue = Number(secondNumber.value);

   let sum = firstElementValue - secondElementValue;

   let divElement = document.getElementById('result');

   divElement.textContent = sum;
}
