class ChristmasDinner {
    constructor(budget){
        this._budget = budget;
        this.dishes = [];
        this.products = [];
        this.guests = {};
    }

    get _budget(){
        return this.budget;
    }
    set _budget(value){
        if(value < 0){
            throw new Error('The budget cannot be a negative number');
        }

        this.budget = value;
    }

    shopping(product){
        let [type, price] = product;

        if(this.budget < Number(price)){
            throw new Error('Not enough money to buy this product');
        }

        this.products.push(type);
        this._budget -= Number(price);

        return `You have successfully bought ${type}!`;
    }

    recipes(obj){
        let haveAllProducts = true;
        let values = Object.values(obj);

        for (const product of values[1]) {
            if(!this.products.includes(product)){
                haveAllProducts = false;
                throw new Error('We do not have this product');
            }
        }

        if(haveAllProducts){
            this.dishes.push({recipeName: values[0], productsList: values[1]});
            return `${values[0]} has been successfully cooked!`;
        }
    }

    inviteGuests(name, dish){
        let meal = this.dishes.find(x=> x.recipeName == dish);
        
        if(meal == undefined){
            throw new Error(`We do not have this dish`);
        }

        if(name in this.guests){
            throw new Error('This guest has already been invited');
        }

        this.guests[name] = meal.recipeName;

        return `You have successfully invited ${name}!`;
    }

    showAttendance(){
        let result = [];

        let values = Object.entries(this.guests);

        for (const guest of values) {
            let dish = this.dishes.find(x=> x.recipeName == guest[1])

            result.push(`${guest[0]} will eat ${dish.recipeName}, which consists of ${dish.productsList.join(', ')}`);
        }

        return result.join('\n');
    }
}

let dinner = new ChristmasDinner(300);

dinner.shopping(['Salt', 1]);
dinner.shopping(['Beans', 3]);
dinner.shopping(['Cabbage', 4]);
dinner.shopping(['Rice', 2]);
dinner.shopping(['Savory', 1]);
dinner.shopping(['Peppers', 1]);
dinner.shopping(['Fruits', 40]);
dinner.shopping(['Honey', 10]);

dinner.recipes({
    recipeName: 'Oshav',
    productsList: ['Fruits', 'Honey']
});
dinner.recipes({
    recipeName: 'Folded cabbage leaves filled with rice',
    productsList: ['Cabbage', 'Rice', 'Salt', 'Savory']
});
dinner.recipes({
    recipeName: 'Peppers filled with beans',
    productsList: ['Beans', 'Peppers', 'Salt']
});

dinner.inviteGuests('Ivan', 'Oshav');
dinner.inviteGuests('Petar', 'Folded cabbage leaves filled with rice');
dinner.inviteGuests('Georgi', 'Peppers filled with beans');

console.log(dinner.showAttendance());



