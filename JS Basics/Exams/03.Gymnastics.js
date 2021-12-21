function gymnastics(input){
    let country = input.shift();

    let device = input.shift();

    let points = 0;


    switch(country){
        case"Russia":
            switch(device){
                case"ribbon":
                    points = 9.100 + 9.400;
                break;
                case"hoop":
                    points = 9.300 + 9.800;
                break;
                case"rope":
                    points = 9.600 + 9.000;
                break;
            }
        break;
        case"Bulgaria":
            switch(device){
                case"ribbon":
                    points = 9.600 + 9.400;
                break;
                case"hoop":
                    points = 9.550 + 9.750;
                break;
                case"rope":
                    points = 9.500 + 9.400;
                break;
            }
        break;
        case"Italy":
            switch(device){
                case"ribbon":
                    points = 9.200 + 9.500;
                break;
                case"hoop":
                    points = 9.450 + 9.350;
                break;
                case"rope":
                    points = 9.700 + 9.150;
                break;
            }
        break;
    }

    let neededPercent = ((20 - points) / 20) * 100;
    console.log(`The team of ${country} get ${points.toFixed(3)} on ${device}.`);
    console.log(`${neededPercent.toFixed(2)}%`);
}

gymnastics(["Bulgaria",
"ribbon"]);
