function song(input){
    let controlNumber = Number(input.shift());
    let result = "";

    for (let a = 1; a <= 9; a++) {
        for (let b = 1; b <= 9; b++) {
            for (let c = 1; c <= 9; c++) {
                for (let d = 1; d <= 9; d++) {
                    
                    let sum = a * b + c * d;

                    if (sum == controlNumber){
                        if (a < b && c > d){
                            result += `${a}${b}${c}${d} `;
                        }
                    }
                }
                
            }
            
        }
        
    }
    console.log(result);
    if (result.length >= 19){
        let pasword = `${result[15]}${result[16]}${result[17]}${result[18]}`;
        console.log(`Password: ${pasword}`);
    }
    else {
        console.log("No!");
    }
}
song(["11"]);