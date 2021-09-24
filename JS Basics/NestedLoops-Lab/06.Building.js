function building(input){

    let floorsCount = Number(input.shift());
    let apartmentsCount = Number(input.shift());
    let output = "";

    let counter = floorsCount;


    for (let floors = floorsCount; floors >= 1; floors--) {
        
        for (let apartments = 0; apartments < apartmentsCount; apartments++) {
            if (counter == floors){
                output += `L${floors}${apartments}`;
            }
            else if (counter % 2 == 1){
                output += `A${floors}${apartments}`;
            }
            else if (counter % 2 == 0){
                output += `O${floors}${apartments}`;
            }

            if (apartments < apartmentsCount - 1){
                output += " ";
            }
        }

        console.log(output);
        output = "";
        counter++;
    }
}

building(["6", "4"]);