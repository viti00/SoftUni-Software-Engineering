function bomb(numbers, params) {
    let [target, power] = params;
  
    for (let i = 0; i < numbers.length; i++) {
      let currentNum = numbers[i];
  
      if (currentNum === target) {
        let startIndex = Math.max(0, i - power);
        let countToEnd = power * 2 + 1;
  
        numbers.splice(startIndex, countToEnd);
        i = i - power - 1; 
      }
    }
    
    console.log(numbers.reduce((a, b) => a + b, 0));
  }

bombNumber([1, 4, 4, 2, 8, 9, 1],
    [9, 3]);
