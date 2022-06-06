function solve(rows, cols){
    debugger;
    let direction =  'right';

    let matrix = [];

    for (let i = 0; i < rows; i++) {
        matrix.push([]);
    }

    let positionRow = 0;
    let positionCol = 0;
    let rowLength = rows - 1;
    let colLength = cols - 1;
    let leftBorder = 0;
    let upBorder = 1;

    let counter = 1;

    while(counter <= rows * cols){
        if(direction == 'right'){
            if(positionCol <= colLength){
                matrix[positionRow][positionCol] = counter;
                positionCol++;
                counter++;
            }
            else{
                positionCol = colLength;
                direction = 'down';
                positionRow++;
                
            }
        }
        else if (direction == 'down'){
            if(positionRow <= rowLength){
                matrix[positionRow][positionCol] = counter;
                positionRow++;
                counter++;
            }
            else {
                positionRow = rowLength;
                direction = 'left';
                positionCol--;
                rowLength--;
            }
        }
        else if (direction == 'left'){
            if(positionCol >= leftBorder){
                matrix[positionRow][positionCol] = counter;
                positionCol--;
                counter++;
            }
            else{
                positionCol = leftBorder;
                direction = 'up';
                positionRow--;
                leftBorder++;
            }
        }
        else if (direction == 'up'){
            if(positionRow >= upBorder){
                matrix[positionRow][positionCol] = counter;
                positionRow--;
                counter++;
            }
            else {
                positionRow = upBorder;
                direction = 'right';
                positionCol++;
                colLength--;
                upBorder++;
            }
        }
    }
    let result = '';
    for (let i = 0; i < rows; i++) {
        for (let j = 0; j < cols; j++) {
           result += `${matrix[i][j]} `;
        }
        result += '\n';
    }

    console.log(result);
}

solve(3, 3);
solve(5,5);