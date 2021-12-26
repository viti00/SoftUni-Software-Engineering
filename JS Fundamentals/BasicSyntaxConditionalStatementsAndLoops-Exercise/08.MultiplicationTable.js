function multiplicationTable(arg){
    let num = Number(arg);

    for (let i = 1; i <= 10; i++) {
        console.log(`${num} X ${i} = ${num * i}`);
        
    }
}

multiplicationTable("5");