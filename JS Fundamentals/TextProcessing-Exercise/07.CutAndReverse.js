function cutAndReverse(input){
    let firstHalf = "";
    let secondHalf = "";

    for (let i = input.length / 2 - 1; i >= 0; i--) {
        firstHalf += input[i];
    }
    for (let j = input.length - 1; j >= input.length/ 2; j--) {
        secondHalf += input[j];
    }

    console.log(firstHalf);
    console.log(secondHalf);
}

cutAndReverse('tluciffiDsIsihTgnizamAoSsIsihT');