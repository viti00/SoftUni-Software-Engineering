function calculator() {
    debugger;
    let firstNum = 0;
    let secondNum =0;
    let res = '';

    return {
        init: (num1, num2, result) => {
            firstNum = document.querySelector(num1);
            secondNum = document.querySelector(num2);

            res = (document.querySelector(result));
        },
        add: ()=> {
            res.value = Number(firstNum.value) + Number(secondNum.value);
        },
        subtract: ()=> {
            res.value = Number(firstNum.value) - Number(secondNum.value);
        } 
    }
}


const calculate = calculator();
calculate.init ('#num1', '#num2', '#result');




