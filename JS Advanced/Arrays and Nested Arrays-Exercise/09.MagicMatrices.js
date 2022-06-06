function solve(input) {
    let isMatrixMagical = true;
    let firstRowSum = 0;
    let firstColSum = 0;

    for (let i = 0; i < 1; i++) {
        for (let j = 0; j < input.length; j++) {
            firstRowSum += input[i][j];
        }
    }
    for (let i = 0; i < input.length; i++) {
        for (let j = 0; j < 1; j++) {
            firstColSum += input[i][j];
        }
    }


    for (let i = 1; i < input.length; i++) {
        let otherRowSum = 0;
        for (let j = 0; j < input.length; j++) {
            otherRowSum += input[i][j];
        }

        if (firstRowSum !== otherRowSum) {
            isMatrixMagical = false;
            break;
        }
    }

    for (let j = 1; j < input.length; j++) {
        let otherColSum = 0;
        for (let i = 0; i < input.length; i++) {
            otherColSum += input[i][j];
        }

        if(firstColSum !== otherColSum){
            isMatrixMagical = false;
            break;
        }
    }

    console.log(isMatrixMagical);
}


solve([[1, 0, 0],
[0, 1, 0],
[0, 1, 0]])