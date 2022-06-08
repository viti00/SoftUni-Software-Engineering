function solve(input){
    let numbers = [];
    debugger;

    const parser = {
        '+'(firstNum, secondNum){
            return firstNum + secondNum;
        },
        '-'(firstNum, secondNum){
            return firstNum - secondNum;
        },
        '*'(firstNum, secondNum){
            return firstNum * secondNum;
        },
        '/'(firstNum, secondNum){
           return firstNum / secondNum;
        }
    }

    for (let i = 0; i < input.length; i++) {
        let type = typeof(input[i]);

        if(type === 'number'){
            numbers.push(input[i]);
        }
        else if (type !== 'number' && numbers.length >= 2) {
            let command = input[i];
            let secondNum = numbers.pop();
            let firstNum = numbers.pop();

            numbers.push(parser[command](firstNum, secondNum));
        }
        else {
            console.log('Error: not enough operands!');
            return;
        }
    }

    if(numbers.length > 1){
        console.log('Error: too many operands!');
        return;
    }
    console.log(numbers.join());
}

solve([
    3,
    4,
    '+']
   )