function solve(input) {
    let neighbors = 0;
    debugger

    for (let row = 0; row < input.length; row++) {
        for (let col = 0; col < input[row].length; col++) {
            let currElement = input[row][col];

            if (row + 1 < input.length && col + 1 < input[row].length) {
                if (currElement == input[row][col + 1]) {
                    neighbors++;
                }

                if (currElement == input[row + 1][col]) {
                    neighbors++;
                }
            }
            else if (col + 1 >= input[row].length && row + 1 >= input.length){
                break;
            }
            else if( col + 1 >= input[row].length){
                if (currElement == input[row + 1][col]) {
                    neighbors++;
                }
            }

            else if (row + 1 >= input.length){
                if (currElement == input[row][col + 1]) {
                    neighbors++;
                }
            }

            

        }
    }

    console.log(neighbors);
}
solve([[2, 2, 5, 7, 4],
    [4, 0, 5, 3, 4],
    [2, 5, 5, 4, 2]]
    )