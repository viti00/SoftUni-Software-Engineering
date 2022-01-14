function firstAndLastKElements(arr){

    let k = Number(arr.shift());

    let firstNumbers = arr.slice(0, k);

    let lastNumbers = arr.slice(-k);


    console.log(firstNumbers.join(' '));
    console.log(lastNumbers.join(' '));
}

firstAndLastKElements([2, 7, 8, 9])