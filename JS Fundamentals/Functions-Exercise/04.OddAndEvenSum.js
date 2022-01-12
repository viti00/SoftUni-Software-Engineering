function oddAndEvenSum(input){

    let text = input.toString();
    
    let even = evenSum(text);
    let odd = oddSum(text);

    console.log(`Odd sum = ${odd}, Even sum = ${even}`);


    function oddSum(text){
        let oddSum =0;
        for (let i = 0; i < text.length; i++) {
            let curr = Number(text[i]);
           if (curr % 2 == 1){
                oddSum += curr;
           }
        }
        return oddSum;
    }
    function evenSum(text){
        let evenSum =0;
        for (let i = 0; i < text.length; i++) {
            let curr = Number(text[i]);
           if (curr % 2 == 0){
                evenSum += curr;
           }
        }
        return evenSum;
    }
}

oddAndEvenSum(1000435);