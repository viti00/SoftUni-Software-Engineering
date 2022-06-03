function solve(input){
    let primaryDiagonal = 0;
    let secondaryDiagonal = 0;

    for (let i = 0; i < input.length; i++) {
        primaryDiagonal += input[i][i];
    }

    let position = input.length - 1;
    for (let j = 0; j < input.length; j++) {
        secondaryDiagonal += input[j][position];
        position--;
    }

    console.log(`${primaryDiagonal} ${secondaryDiagonal}`);
}

solve([[3, 5, 17],
    [-1, 7, 14],
    [1, -8, 89]]   
   )

