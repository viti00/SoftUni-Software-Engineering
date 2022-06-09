function sumTable() {
    let rows = document.querySelectorAll('table tbody tr td');

    let sum = 0;
    index = 0;

    for (const row of rows) {
        index++;
        if(index % 2 == 0){
            sum += Number(row.textContent);
        }
    }

    let sumElement = document.getElementById('sum');
    sumElement.textContent = `${sum}`;
}