function maxSequence(arr){
    let maxSequenceLenght = 0;
    let currSequence = 0;
    let result = "";
    let currResult = "";
    for (let i = 0; i < arr.length - 1; i++) {
        let currNum = arr[i];
       if (currNum == arr[i + 1]){
           currSequence++;
           currResult += arr[i] + " ";
       }
       else{
           currResult += arr[i];
           if (currSequence > maxSequenceLenght){
               maxSequenceLenght = currSequence;
               result = currResult;
           }
           currSequence = 0;
           currResult = "";
       }
    }

    console.log(result);

}

maxSequence([2, 1, 1, 2, 3, 3, 2, 2, 2, 1]);

