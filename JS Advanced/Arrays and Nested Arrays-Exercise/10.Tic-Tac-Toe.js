function solve(input){
    let matrix = [[false, false, false],
                  [false, false, false],
                  [false, false, false]];

    debugger;

    let counter = 0;
    for (const move of input) {
        let moves = move.split(' ');

        let row = Number(moves[0]);
        let col = Number(moves[1]);

        if(matrix[row][col] === false){
            if(counter % 2 == 0){
                matrix[row][col] = 'X';
            }
            else{
                matrix[row][col] = 'O';
            }

            counter++;
        }
        else {
            console.log('This place is already taken. Please choose another!');
        }

        let state = checkState(matrix);

        if(state){
            let winner = matrix[row][col];
            console.log(`Player ${winner} wins!`);
            let result = printMatrix(matrix);
            console.log(result);
            return;
        }
        if(counter > 8){
            break;
        }
    }

    console.log(`The game ended! Nobody wins :(`);
    let result = printMatrix(matrix);
    console.log(result);

    function checkState(matrix){
        if(matrix[0][0] === matrix[0][1] && matrix[0][0] === matrix[0][2] && matrix[0][0] !== false){
            return true;
        }
        if(matrix[1][0] === matrix[1][1] && matrix[1][0] === matrix[1][2]&& matrix[1][0] !== false){
            return true;
        }
        if(matrix[2][0] === matrix[2][1] && matrix[2][0] === matrix[2][2]&& matrix[2][0] !== false){
            return true;
        }
        if(matrix[0][0] === matrix[1][0] && matrix[0][0] === matrix[2][0]&& matrix[0][0] !== false){
            return true;
        }
        if(matrix[0][1] === matrix[1][1] && matrix[0][1] === matrix[2][1]&& matrix[0][1] !== false){
            return true;
        }
        if(matrix[0][2] === matrix[1][2] && matrix[0][2] === matrix[2][2]&& matrix[0][2] !== false){
            return true;
        }
        if(matrix[0][0] === matrix[1][1] && matrix[0][0] === matrix[2][2]&& matrix[0][0] !== false){
            return true;
        }
        if(matrix[0][2] === matrix[1][1] && matrix[0][2] === matrix[2][0]&& matrix[0][2] !== false){
            return true;
        }
    
        return false;
    }
    function printMatrix(matrix){
        let result = '';
        for (let i = 0; i < matrix.length; i++) {
            for (let j = 0; j < matrix[i].length; j++) {
                result += `${matrix[i][j]}\t`
            }
            result += '\n';
        }
    
        return result;
    }
}




solve(["0 1",
    "0 0",
    "0 2",
    "2 0",
    "1 0",
    "1 2",
    "1 1",
    "2 1",
    "2 2",
    "0 0"]
)