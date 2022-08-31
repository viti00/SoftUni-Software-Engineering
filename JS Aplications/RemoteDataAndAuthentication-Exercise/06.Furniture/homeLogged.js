async function solve() {
     
    let tbodyElement = document.getElementsByTagName('tbody')[0];
    tbodyElement.querySelectorAll('tr').forEach(tr => tr.remove());

    let orders = document.getElementsByClassName('orders')[0];
    orders.querySelectorAll('p').forEach(p => p.remove());

    let divElement = document.getElementsByClassName('col-md-12')[0];
    let buyBtn = divElement.querySelectorAll('button')[1];

    let logOutBtn = document.getElementById('logoutBtn');

    let allOrdersBtn = divElement.querySelectorAll('button')[2];

    let form = document.getElementById('register-product');

    form.addEventListener('submit', register);
    buyBtn.addEventListener('click', buyProduct);
    allOrdersBtn.addEventListener('click', listAllOrders);
    logOutBtn.addEventListener('click', logout);

    getProducts();

    async function logout(){
        let response = await fetch('http://localhost:3030/users/logout', {
            method: 'get',
            headers: {
                'X-Authorization': localStorage.getItem('token')
            }
        })
        
        location.assign('./login.html')
    }

    async function listAllOrders() {
        let orders = document.getElementsByClassName('orders')[0];
        orders.querySelectorAll('p').forEach(p => p.remove());

        let respones = await fetch('http://localhost:3030/users/me', {
            method: 'get',
            headers: {
                'X-Authorization': localStorage.getItem('token')
            }
        });
        let result = await respones.json();
        let id = result._id;

        let allOrdersResponse = await fetch(`http://localhost:3030/data/orders?where=_ownerId%3D"${id}"`);
        let allOrdersResult = await allOrdersResponse.json();

        let productNames = [];
        let totalPrice = 0;

        for (const product of allOrdersResult) {
            let {name, price} = product;

            productNames.push(name);
            totalPrice += Number(price);
        }

        let productsNamePElement = document.createElement('p');
        productsNamePElement.textContent = 'Bought furniture: ';
        let spanNamesElement = document.createElement('span');
        spanNamesElement.textContent = productNames.join(', ');
        productsNamePElement.appendChild(spanNamesElement);

        let pricePElement = document.createElement('p');
        pricePElement.textContent = 'Total price: ';
        let spanPriceElement = document.createElement('span');
        spanPriceElement.textContent = `${totalPrice} $`;
        pricePElement.appendChild(spanPriceElement);

        orders.appendChild(productsNamePElement);
        orders.appendChild(pricePElement);
    }

    async function buyProduct() {
         
        let checkBoxes = tbodyElement.querySelectorAll('input');

        for (const checkbox of checkBoxes) {
            if (checkbox.checked) {
                let parent = checkbox.parentNode.parentNode;

                let name = parent.children[1].children[0].textContent;
                let price = Number(parent.children[2].children[0].textContent);

                let response = await fetch('http://localhost:3030/data/orders', {
                    method: 'post',
                    headers: {
                        'Content-Type': 'aplication/json',
                        'X-Authorization': localStorage.getItem('token')
                    },
                    body: JSON.stringify({
                        name: name,
                        price: price
                    })

                })
                let result = await response.json();

                checkbox.checked = false;
            }
        }
    }
    async function register(e) {
         
        e.preventDefault();

        let formData = new FormData(e.target);

        let name = formData.get('name');
        let price = formData.get('price');
        let factor = formData.get('factor');
        let img = formData.get('img');
        let url = 'http://localhost:3030/data/furniture';

        e.target.reset();

        let registerResponse = await fetch(url, {
            method: 'post',
            headers: {
                'Content-Type': 'aplication/json',
                'X-Authorization': localStorage.getItem('token')
            },
            body: JSON.stringify({
                name: name,
                price: price,
                decFactor: factor,
                img: img
            })
        })

        let registerResult = await registerResponse.json();
        let product = createProduct(registerResult);
        tbodyElement.appendChild(product);
    }

    async function getProducts() {
        let response = await fetch('http://localhost:3030/data/furniture');
        let result = await response.json();

        for (const product of result) {
            let createdProduct = createProduct(product);

            tbodyElement.appendChild(createdProduct);
        }
    }
}
function createProduct(product) {
     
    let { name, price, decFactor, img } = product;

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
    inputElement.disabled = false;
    tdCheckBoxElement.appendChild(inputElement);

    trElement.appendChild(tdImgElement);
    trElement.appendChild(tdNameElement);
    trElement.appendChild(tdPriceElement);
    trElement.appendChild(tdFactorElement);
    trElement.appendChild(tdCheckBoxElement);

    return trElement;
}

solve()