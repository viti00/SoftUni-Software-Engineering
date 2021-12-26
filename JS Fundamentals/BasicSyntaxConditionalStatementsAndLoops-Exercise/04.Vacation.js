function vacantion(arg1, arg2, arg3) {
    let groupCount = Number(arg1);
    let groupType = arg2;
    let day = arg3;
    debugger;
    let totalPrice = 0;

    switch (groupType) {
        case "Students":
            switch (day) {
                case"Friday":
                    totalPrice = groupCount * 8.45;
                    break;
                case"Saturday":
                    totalPrice = groupCount * 9.80;
                    break;
                case"Sunday":
                    totalPrice = groupCount * 10.46;
                    break;
            }
            if (groupCount >= 30 && groupCount <= 99){
                totalPrice *= 0.85;
            }
            break;
        case "Business":
            switch (day) {
                case"Friday":
                    totalPrice = groupCount * 10.90;
                    break;
                case"Saturday":
                    totalPrice = groupCount * 15.60;
                    break;
                case"Sunday":
                    totalPrice = groupCount * 16;
                    break;
            }
            if (groupCount >= 100){
                let freeGuestsPrice = 10 * (totalPrice / groupCount);
                totalPrice -= freeGuestsPrice;
            }
            break;
        case "Regular":
            switch (day) {
                case"Friday":
                    totalPrice = groupCount * 15;
                    break;
                case"Saturday":
                    totalPrice = groupCount * 20;
                    break;
                case"Sunday":
                    totalPrice = groupCount *22.50;
                    break;
            }
            if (groupCount >= 10 && groupCount <= 20){
                totalPrice *= 0.95;
            }
            break;
    }
    console.log(`Total price: ${totalPrice.toFixed(2)}`);
}

vacantion(40,
    "Regular",
    "Saturday"    
    );