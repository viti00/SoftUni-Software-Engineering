function distinctArray(arr){
  let newArr =[];

  for (let i = 0; i < arr.length; i++) {
      let currElement = arr[i];

      if(!newArr.includes(currElement)){
        newArr.push(currElement);
      }
  }

  arr = newArr;

  console.log(arr.join(" "));
}

distinctArray([7, 8, 9, 7, 2, 3, 4, 1, 2]);