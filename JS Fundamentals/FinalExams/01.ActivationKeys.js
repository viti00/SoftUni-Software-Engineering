function activationKey(arr){
    let key = arr.shift();
    debugger;

    let command = arr.shift();

    while(command != "Generate"){
        let  curr = command.split(">>>");
        let cmdType = curr[0];

        switch(cmdType){
            case"Contains":
                let word = curr[1];
                if(key.indexOf(word) >= 0){
                    console.log(`${key} contains ${word}`);
                }
                else{
                    console.log(`Substring not found!`);
                }
            break;
            case"Flip": 
                let upperOrLower = curr[1];
                let start = Number(curr[2]);
                let end = Number(curr[3]);
                let cut = "";
                if (upperOrLower == "Upper"){
                    cut= key.slice(start, end);
                    key = key.replace(cut, cut.toUpperCase());
                    
                }
                else if (upperOrLower == "Lower"){
                    cut = key.slice(start, end);
                    key = key.replace(cut, cut.toLocaleLowerCase());
                }

                console.log(key);
            break;
            case"Slice":
                let startIndex = Number(curr[1]);
                let endIndex = Number(curr[2]);
                let slice = key.slice(startIndex, endIndex);

                key = key.replace(slice,"");
                console.log(key);
            break;
        }

        command= arr.shift();
    }

    console.log(`Your activation key is: ${key}`)
}
activationKey((["abcdefghijklmnopqrstuvwxyz",
"Slice>>>2>>>6",
"Flip>>>Upper>>>3>>>14",
"Flip>>>Lower>>>5>>>7",
"Contains>>>def",
"Contains>>>deF",
"Generate"]))