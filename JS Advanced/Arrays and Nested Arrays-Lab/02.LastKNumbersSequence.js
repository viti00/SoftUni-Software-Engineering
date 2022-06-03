function solve(n, k){
    debugger
    let arr = [];
    arr.push(1);

    for (let i = 1; i < n; i++) {
        let newElement = 0;
        for (let j = i - 1; j >= i - k; j--) {
            newElement += arr[j];
            if(j === 0){
                break;
            }
        }

        arr.push(newElement);
    }

    return arr;
}

console.log(solve(6,3))