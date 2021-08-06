function fruitOrVegetable(input){
    let prodcut = input[0];

    if(prodcut == "banana" || prodcut == "kiwi" || prodcut == "apple" || prodcut == "cherry" || prodcut == "lemon" || prodcut == "grapes" ){
        console.log("fruit");
    }
    else if (prodcut == "tomato" || prodcut == "cucumber" || prodcut == "pepper" || prodcut == "carrot" ){
        console.log("vegetable");
    }
    else {
        console.log("unknown");
    }
}

fruitOrVegetable(["tomato"]);