function orders(arg1, arg2){
    let product = arg1;
    let quantity = Number(arg2);

    console.log(calculate(product, quantity));

    function calculate(product, quantity){
        let totalCost = 0;
        switch (product) {
            case "water":
                totalCost = quantity * 1.00;
                break;
            case"coffee":
                totalCost = quantity * 1.50;
                break;
            case"coke":
                totalCost = quantity * 1.40;
                break;
            case"snacks":
                totalCost = quantity * 2.00;
                break;
        }
        return totalCost.toFixed(2);
    }
}

orders("water", "5");