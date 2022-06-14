function solve() {

  let generateBtn = document.getElementsByTagName('button')[0];
  let inputTextArea = document.getElementsByTagName('textarea')[0];

  let buyBtn = document.getElementsByTagName('button')[1];
  let ouutputArea = document.getElementsByTagName('textarea')[1];


  generateBtn.addEventListener('click', function () {
    let arr = Array.from(JSON.parse(inputTextArea.value));
    let tbodyElement = document.querySelector('tbody');


    for (const { img: img, name: name, price: price, decFactor: decFactor } of arr) {
      let newTrElement = document.createElement('tr');

      let newImgTdElement = document.createElement('td');
      let newImgElement = document.createElement('img');
      newImgElement.setAttribute('src', img);
      newImgTdElement.appendChild(newImgElement);

      let newNameTdElement = document.createElement('td');
      let newNameElement = document.createElement('p');
      newNameElement.textContent = name;
      newNameTdElement.appendChild(newNameElement);

      let newPriceTdElement = document.createElement('td');
      let newPriceElement = document.createElement('p');
      newPriceElement.textContent = price;
      newPriceTdElement.appendChild(newPriceElement);

      let newDecFactorTdElement = document.createElement('td');
      let newDecFactorElement = document.createElement('p');
      newDecFactorElement.textContent = decFactor;
      newDecFactorTdElement.appendChild(newDecFactorElement);

      let newMarkTdElement = document.createElement('td');
      let newMarkElement = document.createElement('input');
      newMarkElement.setAttribute('type', 'checkbox');
      newMarkTdElement.appendChild(newMarkElement);

      newTrElement.appendChild(newImgTdElement);
      newTrElement.appendChild(newNameTdElement);
      newTrElement.appendChild(newPriceTdElement);
      newTrElement.appendChild(newDecFactorTdElement);
      newTrElement.appendChild(newMarkTdElement)

      tbodyElement.appendChild(newTrElement);
    }
  });

  buyBtn.addEventListener('click', function () {
    let output = [];
    let toBuy = Array.from(document.querySelectorAll('input[type="checkbox"]'))
            .filter(e => e.checked === true)
            .map(e => e.parentNode.parentNode);
 
        let bought = toBuy.map(e => Array.from(e.querySelectorAll('td'))[1].innerText)
            .join(', ');
 
        output.push(`Bought furniture: ${bought}`);
 
        let totalPrice = toBuy.map(e => Array.from(e.querySelectorAll('td'))[2].innerText).map(Number)
            .reduce((acc, current) => acc + current, 0);
 
        output.push(`Total price: ${totalPrice.toFixed(2)}`);
 
        let averageFactor = toBuy.map(e => Array.from(e.querySelectorAll('td'))[3].innerText).map(Number)
            .reduce((acc, current) => acc + current, 0) / toBuy.length;
 
        output.push(`Average decoration factor: ${averageFactor}`);
 
        ouutputArea.value = output.join('\n');

  });
}