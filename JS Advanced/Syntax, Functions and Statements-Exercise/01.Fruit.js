function solve(fruit, grams, pricePerKilogram){
    let kilograms = grams / 1000;

    let totalPrice = kilograms * pricePerKilogram;

    console.log(`I need $${totalPrice.toFixed(2)} to buy ${kilograms.toFixed(2)} kilograms ${fruit}.`)
}

solve('orange', 2500, 1.80)