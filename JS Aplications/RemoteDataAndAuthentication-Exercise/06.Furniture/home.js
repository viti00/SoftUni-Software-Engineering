async function solve() {
    let tbodyElement = document.getElementsByTagName('tbody')[0];
    tbodyElement.querySelectorAll('tr').forEach(tr => tr.remove());

    

    let response = await fetch('http://localhost:3030/data/furniture');
    let result = await response.json();

    for (const product of result) {
        let createdProduct = createProduct(product);
        tbodyElement.appendChild(createdProduct);
    }
}

function createProduct(product){
    let {name, price, decFactor, img} = product;

    let trElement = document.createElement("tr")

    let tdImgElement = document.createElement('td');
    let imgElement = document.createElement('img');
    imgElement.setAttribute('src', img);
    tdImgElement.appendChild(imgElement);

    let tdNameElement = document.createElement('td');
    let nameElement = document.createElement("p");
    nameElement.textContent = name;
    tdNameElement.appendChild(nameElement);

    let tdPriceElement = document.createElement('td');
    let priceElement = document.createElement('p');
    priceElement.textContent = Number(price);
    tdPriceElement.appendChild(priceElement);

    let tdFactorElement = document.createElement('td');
    let factorElement = document.createElement('p');
    factorElement.textContent = Number(decFactor);
    tdFactorElement.appendChild(factorElement);

    let tdCheckBoxElement = document.createElement('td');
    let inputElement = document.createElement('input');
    inputElement.setAttribute('type', "checkbox");
    inputElement.disabled = true;
    tdCheckBoxElement.appendChild(inputElement);

    trElement.appendChild(tdImgElement);
    trElement.appendChild(tdNameElement);
    trElement.appendChild(tdPriceElement);
    trElement.appendChild(tdFactorElement);
    trElement.appendChild(tdCheckBoxElement);

    return trElement;
}

solve();