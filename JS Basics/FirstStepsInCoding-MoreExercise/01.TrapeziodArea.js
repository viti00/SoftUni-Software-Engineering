function calucateArea(input){
    let sideB1 = Number(input[0]);
    let sideB2 = Number(input[1]);
    let height =  Number(input[2]);

    let area = (sideB1 + sideB2) * height / 2;

    console.log(area.toFixed(2));
}

calucateArea(["8", "13", "7"]);