function solve(input){
    let matrix = input.map(row => row.split(' ').map(Number));

    let primaryDiagonalSum = 0;
    let secondaryDiagonalSum = 0;

    for (let i = 0; i < matrix.length; i++) {
        primaryDiagonalSum += matrix[i][i];
    }

    let position = matrix.length - 1;
    for (let i = 0; i < matrix.length; i++) {
        secondaryDiagonalSum += matrix[i][position];
        position--;
    }

    let primaryDiagonalPosition = 0;
    let secondaryDiagonalPosition = matrix.length - 1;
    if(primaryDiagonalSum === secondaryDiagonalSum){
        for (let i = 0; i < matrix.length; i++) {
            for (let j = 0; j < matrix.length; j++) {
                if(j !== primaryDiagonalPosition && j !== secondaryDiagonalPosition){
                    matrix[i][j] = primaryDiagonalSum;
                }
            }
            primaryDiagonalPosition++;
            secondaryDiagonalPosition--;
        }
    }

    let result = '';
    for (let i = 0; i < matrix.length; i++) {
        for (let j = 0; j < matrix.length; j++) {
           result += `${matrix[i][j]} `;
        }
        result += '\n';
    }

    console.log(result);
}

solve(['5 3 12 3 1',
'11 4 23 2 5',
'101 12 3 21 10',
'1 4 5 2 2',
'5 22 33 11 1']
)