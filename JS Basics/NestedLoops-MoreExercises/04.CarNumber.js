function carNumber(input){
    debugger;
    let startIndex = Number(input.shift());
    let endIndex = Number(input.shift());

    let result = "";

    for (let first = startIndex; first <= endIndex; first++) {
        
        for (let second = startIndex; second <= endIndex; second++) {
            for (let third = startIndex; third <= endIndex; third++) {
                
                 for (let fourth = startIndex; fourth <= endIndex; fourth++) {
                     
                   if (first > fourth){
                        if ((second + third) % 2 == 0){
                            if (first % 2 == 0){
                                if (fourth % 2 == 1){
                                    result += `${first}${second}${third}${fourth}` + " ";
                                }
                            }
                            else if (first % 2 == 1){
                                if (fourth % 2 == 0){
                                    result += `${first}${second}${third}${fourth}` + " ";
                                }
                            }
                        }
                   }
                 }
                
            }
            
        }
     }

     console.log(result);
    
}

carNumber(["2", "3"]);