class Restaurant{
    constructor(budgetMoney){
        this.budgetMoney = budgetMoney;
        this.menu = {};
        this.stockProducts = {};
        this.history = [];
    }

    loadProducts(arr){
        let result = [];
        for (const product of arr) {
            let[name, quantity, totalPrice] = product.split(' ');

            if(this.budgetMoney >= totalPrice){
                
                if(this.stockProducts.hasOwnProperty(name)){
                    this.stockProducts[name] += Number(quantity);
                }
                else {
                    this.stockProducts[name] = Number(quantity);
                }
                this.budgetMoney -= totalPrice;

                this.history.push(`Successfully loaded ${quantity} ${name}`)
                result.push(`Successfully loaded ${quantity} ${name}`);
            }
            else {
                this.history.push(`There was not enough money to load ${quantity} ${name}`);
                result.push(`There was not enough money to load ${quantity} ${name}`);
            }
        }
        return this.history.join('\n');
    }

    addToMenu(productName, ingredientsArr, price){
        if( this.menu.hasOwnProperty(productName)){
            return `The ${productName} is already in the our menu, try something different.`;
        }
        else {
            if(Object.keys(this.menu).length == 0){
                this.menu[productName] = {products: ingredientsArr, price: Number(price)};
                return `Great idea! Now with the ${productName} we have 1 meal in the menu, other ideas?`;
            }
            else {
                this.menu[productName] = {products: ingredientsArr, price: Number(price)};
                return `Great idea! Now with the ${productName} we have ${Object.keys(this.menu).length} meals in the menu, other ideas?`;
            }
        }
    }

    showTheMenu(){
        if(Object.keys(this.menu) == 0){
            return `Our menu is not ready yet, please come later...`;
        }
        else {
            debugger;
            let result = [];
            for (const key in this.menu) {
               result.push(`${key} - $ ${Object.values(this.menu[key])[1]}`);
            }
            return result.join('\n')
        }
    }

    makeTheOrder(meal){
        if(this.menu.hasOwnProperty(meal)){
            let ingredients = Object.values(this.menu[meal])[0];
            let haveAllProducts = true;
            for (const ingredient of ingredients) {
                let [name, quantity] = ingredient.split(' ');
                if(this.stockProducts.hasOwnProperty(name)){
                    if(this.stockProducts[name] - Number(quantity) < 0){
                        haveAllProducts = false;
                        break;
                    }
                }
                else{
                    haveAllProducts = false;
                    break;
                }
            }

            if(haveAllProducts){
                for (const ingredient of ingredients) {
                    let [name, quantity] = ingredient.split(' ');

                   this.stockProducts[name] -= Number(quantity);
                }

                this.budgetMoney += this.menu[meal].price;

                return  `Your order (${meal}) will be completed in the next 30 minutes and will cost you ${this.menu[meal].price}.`;
            }
            else {
                return `For the time being, we cannot complete your order (${meal}), we are very sorry...`;
            }
        }
        else {
            return `There is not ${meal} yet in our menu, do you want to order something else?`
        }
    }
}


let kitchen = new Restaurant(1000);
kitchen.loadProducts(['Yogurt 30 3', 'Honey 50 4', 'Strawberries 20 10', 'Banana 5 1']);
kitchen.addToMenu('frozenYogurt', ['Yogurt 1', 'Honey 1', 'Banana 1', 'Strawberries 10'], 9.99);
console.log(kitchen.makeTheOrder('frozenYogurt'));


