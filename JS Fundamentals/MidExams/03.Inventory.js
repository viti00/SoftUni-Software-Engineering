function inventory(arr){
    let inventory = arr.shift().split(", ");
    debugger;


    while(true){
        let curr = arr.shift().split(" - ")
        let command = curr[0];
        if (command == "Craft!"){
            break;
        }
        let item = curr[1];

        switch(command){
            case"Collect":
                if (!inventory.find(i => i == item)){
                    inventory.push(item);
                }
            break;
            case"Drop":
                if(inventory.find(i => i == item)){
                    inventory = inventory.filter(x => x != item);
                }
            break;
            case"Combine Items":
                item = item.split(":");
                let oldItem = item[0];
                let newItem = item[1];
                if (inventory.find (i => i == oldItem)){
                    let index = inventory.indexOf(oldItem);
                    inventory.splice(index + 1, 0, newItem);
                }
            break;
            case"Renew":
                if (inventory.find(i => i == item)){
                    inventory = inventory.filter(i => i != item);
                    inventory.push(item);
                }
            break;
        }

    }

    console.log(inventory.join(", "));
}

inventory([
    'Iron, Sword',
    'Drop - Bronze',
    'Combine Items - Sword:Bow',
    'Renew - Iron',
    'Craft!'
  ]);