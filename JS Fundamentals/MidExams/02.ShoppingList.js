function shoppingList(arr){
    debugger;
    let products = arr.shift().split("!");
    
    let command = arr.shift();

    while(command != "Go Shopping!"){
        command = command.split(" ");
        let type = command[0];
        let item = command[1];

        switch(type){
            case"Urgent":
                if (!products.find(i => i == item)){
                    products.unshift(item);
                }
            break;
            case"Unnecessary":
                if (products.find(i => i == item)){
                    products = products.filter(i => i != item);
                }
            break;
            case"Correct":
                let newItem = command[2];
                if (products.find(i => i == item)){
                    let index = products.indexOf(item);
                    products[index] = newItem;
                }
            break;
            case"Rearrange":
                if (products.find(i => i == item)){
                    products = products.filter(i => i != item);
                    products.push(item);
                }
            break;
        }

        command = arr.shift();
    }

    console.log(products.join(", "));
}

shoppingList(["Milk!Pepper!Salt!Water!Banana",
"Urgent Salt",
"Unnecessary Grapes",
"Correct Pepper Onion",
"Rearrange Grapes",
"Correct Tomatoes Potatoes",
"Go Shopping!"]);