function solve(number, operation1, operation2, operation3, operation4, operation5) {
    let num = Number(number);

    for (let i = 1; i < arguments.length; i++) {
        switch (arguments[i]) {
            case "chop":
                num = num / 2;
                console.log(num);
                break;
            case "dice":
                num = Math.sqrt(num);
                console.log(num);
                break;
            case "spice":
                num = num + 1;
                console.log(num);
                break;
            case "bake":
                num = num * 3;
                console.log(num);
                break;
            case "fillet":
                num -= num * 0.2;
                console.log(num);
                break;
        }
    }
}

solve('32', 'chop', 'chop', 'chop', 'chop', 'chop')