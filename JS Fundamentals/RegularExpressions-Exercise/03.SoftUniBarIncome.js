function solve(arr) { 
    arr.pop();
    let totalIncome = 0;
    arr.forEach((line) => {
        let pattern = /%([A-Z][a-z]+)%[^|$%.]*<(\w+)>[^|$%.]*\|([0-9]+)\|[^|$%.]*?([0-9]+\.?[0-9]*)\$/gm; 
        let result = pattern.exec(line);
	if (result) {
		let currentSum = Number(result[3]) * Number(result[4]);
		console.log(`${result[1]}: ${result[2]} - ${currentSum.toFixed(2)}`);
		totalIncome += currentSum;
	}        
    });
    console.log(`Total income: ${totalIncome.toFixed(2)}`); 
}