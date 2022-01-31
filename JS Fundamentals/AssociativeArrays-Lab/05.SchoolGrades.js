function schoolGrades(arr){
    let notebook = new Map();

    for (const data of arr) {
        let dataArr = data.split(" ");
        let name = dataArr[0];
        let grades = dataArr.splice(1, dataArr.length).map(Number);
        
        if (!notebook.has(name)){
            notebook.set(name, []);
            notebook.set(name, notebook.get(name).concat(grades));
        }
        else {
            notebook.set(name, notebook.get(name).concat(grades));
        }
     
    }
    	let sorted = Array.from(notebook.entries()).sort((a, b) => sorting(a, b));
    for (const kvp of sorted) {
        console.log(`${kvp[0]}: ${kvp[1].join(", ")}`);
    }

    function sorting(a, b){
        let aSum = 0;

        for (let i = 0; i < a[1].length; i++) {
            aSum += a[1][i];
        }

        let bSum = 0;
        for (let j = 0; j < b[1].length; j++) {
            bSum += b[1][j];
        }

        let aAverage = aSum / a[1].length;
        let bAverage = bSum / b[1].length;

        return aAverage - bAverage;
    }
}

schoolGrades(['Lilly 4 6 6 5',
'Tim 5 6',
'Tammy 2 4 3',
'Tim 6 6']);