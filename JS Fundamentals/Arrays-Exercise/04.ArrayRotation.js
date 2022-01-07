function rotation(arr, arg){
    let rotationCount = Number(arg);
    debugger;

    for (let i = 1; i <= rotationCount; i++) {
        let element = arr[0];

        for (let j = 0; j < arr.length - 1; j++) {
            arr[j] = arr[j + 1];
        }
        arr[arr.length - 1] = element;
        
    }

    console.log(arr.join(' '));
}

rotation([51, 47, 32, 61, 21], 2);