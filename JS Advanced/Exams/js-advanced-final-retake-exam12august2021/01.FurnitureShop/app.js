window.addEventListener('load', solve);

function solve() {
    let addBtn = document.getElementById('add');

    addBtn.addEventListener('click', add);

    function add(e){
        e.preventDefault();

        let modelElement = document.getElementById('model');

        let yearElement = document.getElementById('year');

        let descriptionElement = document.getElementById('description');

        let priceElement = document.getElementById('price');

        let tBodyElement = document.getElementById('furniture-list');

        let trInfoElement = document.createElement('tr');
        trInfoElement.setAttribute('class', 'info');

        let firstTdElement = document.createElement('td');
        firstTdElement.textContent = modelElement.value;

        let secondTdElement = document.createElement('td');
        secondTdElement.textContent = Number(priceElement.value).toFixed(2);

        let thirdTdElement = document.createElement('td');

        let moreBtn = document.createElement('button');
        moreBtn.setAttribute('class', 'moreBtn');
        moreBtn.textContent = 'More Info';

        let buyBtn = document.createElement('button');
        buyBtn.setAttribute('class', 'buyBtn');
        buyBtn.textContent = 'Buy it';
        
        thirdTdElement.appendChild(moreBtn);
        thirdTdElement.appendChild(buyBtn);

        trInfoElement.appendChild(firstTdElement);
        trInfoElement.appendChild(secondTdElement);
        trInfoElement.appendChild(thirdTdElement);

        let trHiddenElement = document.createElement('tr');
        trHiddenElement.setAttribute('class', 'hide');

        let hiddenTdYearElement = document.createElement('td');
        hiddenTdYearElement.textContent = `Year: ${yearElement.value}`;

        let hiddenDescriptionElement = document.createElement('td');
        hiddenDescriptionElement.setAttribute('colspan', '3');
        hiddenDescriptionElement.textContent = `Description: ${descriptionElement.value}`;

        trHiddenElement.appendChild(hiddenTdYearElement);
        trHiddenElement.appendChild(hiddenDescriptionElement);


        if(modelElement.value.length > 0 && Number(yearElement.value) > 0 && Number(priceElement.value) > 0 && descriptionElement.value.length > 0){
            tBodyElement.appendChild(trInfoElement);
            tBodyElement.appendChild(trHiddenElement);

            modelElement.value = '';
            yearElement.value = '';
            descriptionElement.value = '';
            priceElement.value = '';

            moreBtn.addEventListener('click', moreInfo);
            buyBtn.addEventListener('click', buyIt);

            function moreInfo(){
                if(moreBtn.textContent == 'More Info'){
                    trHiddenElement.style.display = 'contents';
                    moreBtn.textContent = 'Less Info';
                }
                else if(moreBtn.textContent == 'Less Info'){
                    trHiddenElement.style.display = 'none';
                    moreBtn.textContent = 'More Info';
                }
            }

            function buyIt(e){
                debugger;
                let totalPriceElement = document.getElementsByClassName('total-price')[0];

                let parentElement = e.target.parentNode;
                let tdPrice = parentElement.previousSibling;
                
                totalPriceElement.textContent = (Number(totalPriceElement.textContent) + Number(tdPrice.textContent)).toFixed(2);

                parentElement.parentNode.innerHTML = '';
                parentElement.parentNode.nextElementSibling.innerHTML = '';
            }
        }
    }
}
