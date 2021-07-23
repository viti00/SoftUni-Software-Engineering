function calcolateArea(input){
    let r = Number(input[0]);

    let area = Math.PI * Math.pow(r,2);
    
    let perimeter = 2 * Math.PI * r;

    console.log(area.toFixed(2));
    console.log(perimeter.toFixed(2));
}

calcolateArea(["35.875"]);