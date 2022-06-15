function solution(){
    let result = '';

    return {
        append: (e) =>{
            result += e;
        },
        removeStart: (e) => {
            result = result.substring(e);
        },
        removeEnd: (e) => {
            result = result.substring(0, result.length - e)
        },
        print(){
            console.log(result);
        }
    }
}


let firstZeroTest = solution();

firstZeroTest.append('hello');
firstZeroTest.append('again');
firstZeroTest.removeStart(3);
firstZeroTest.removeEnd(4);
firstZeroTest.print();
