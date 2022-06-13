function solve() {
   let buttonElements = document.getElementsByTagName('button');

   let textArea = document.getElementsByTagName("textarea")[0];

   let products = {};

   Array.from(buttonElements).forEach(b => {
      b.addEventListener('click', (e) => {
         if(e.target.className === 'add-product'){
            let currElement = e.target.parentElement;

            let price = currElement.nextElementSibling.innerHTML;
            let product = currElement.previousElementSibling.children[0].innerHTML;

            if(!products.hasOwnProperty(product)){
               products[product] = 0;
            }

            products[product] += Number(price);

            textArea.value += `Added ${product} for ${price} to the cart.\n`;
         }
         else {

            let buttons = document.querySelectorAll('button');
            buttons.forEach(b=> b.disabled = true);
            let totalPrice = 0;
            let listProducts = [];
            for (const key in products) {
               listProducts.push(key);
               totalPrice += Number(products[key]);
            }

            textArea.value += `You bought ${listProducts.join(', ')} for ${totalPrice.toFixed(2)}.`;
         }
         
      })
   })

}