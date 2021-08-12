function solve(input) {
    let result = 0;
    let i = 0;
    let n = input[i];

    while (n >= 0) {
        result = n * 2;
        console.log(`Result: ${result.toFixed(2)}`);
        i++;
        n = input[i];
    }

    if (n < 0) {
        console.log('Negative number!');
    }
}

solve(["12", "43.2144", "12.3", "543.23", "-12"])