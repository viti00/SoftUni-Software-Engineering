function convert(input){
    let celsius = Number(input);

    let fahrenheit = celsius * 1.8 + 32;

    console.log(fahrenheit.toFixed(2));
}

convert("32.3");