function solve(input){
    let names = input.sort((a, b) => a.localeCompare(b));

    let counter = 1;

    for (const name of names) {
        console.log(`${counter}.${name}`)
        counter++;
    }
}

solve(["John", "Bob", "Christina", "Ema"])