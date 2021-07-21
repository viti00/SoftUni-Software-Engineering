function convert(input){
    let radian = Number(input);
    let degree = radian * 180 / Math.PI;
    console.log(degree.toFixed(0));
}

convert("6.2832");