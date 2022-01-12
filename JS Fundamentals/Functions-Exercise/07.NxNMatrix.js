function nxnMatrix(arg){
    let n = Number(arg);
    let result = "";

    for (let i = 1; i <= n; i++) {
        for (let j = 1; j <= n - 1; j++) {
            result += `${n} `;
        }
        result += n;
        result += "\n";
    }

    console.log(result);
}

nxnMatrix("3");