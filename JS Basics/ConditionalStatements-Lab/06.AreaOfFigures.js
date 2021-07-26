function areaOfFigures(input){
    let figureType = input[0];
    let area;
    if (figureType == "square"){
        let side = input[1];
        area = side * side;
        
    }
    else if (figureType == "triangle"){
        let side = input[1];
        let h = input[2];

        area = side / 2 * h;
    }
    else if (figureType == "rectangle"){
        let sideA = input[1];
        let sideB = input[2];

        area = sideA * sideB;
    }
    else if (figureType == "circle"){
        let r = input[1];
        area = Math.PI * Math.pow(r, 2);
    }

    console.log(area);
}

areaOfFigures(["square", "5"]);