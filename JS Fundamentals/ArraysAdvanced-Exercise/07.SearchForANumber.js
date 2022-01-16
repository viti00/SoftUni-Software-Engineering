function searchForNumber(arr1, arr2){
    debugger;
    let numToGet = arr2.shift();
    let deleteCount = arr2.shift();
    let neededNum = arr2.shift();


    arr1 = arr1.slice(0, numToGet);

    arr1.splice(0, deleteCount);

    arr1 = arr1.filter(x => x === neededNum);

    console.log(`Number ${neededNum} occurs ${arr1.length} times.`);
}

searchForNumber([5, 2, 3, 4, 1, 6],
    [5, 2, 3]
    );