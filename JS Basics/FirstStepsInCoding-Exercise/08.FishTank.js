function calculateVolume(input){
    let lenght = Number(input[0]);
    let width = Number(input[1]);
    let hight = Number(input[2]);
    let percent = Number(input[3]);

    let centimeters = lenght * width * hight;
    let litters = centimeters * 0.001;

    let finalLitters = litters * (1- (percent / 100));

    console.log(finalLitters);
}

calculateVolume(["85", "75", "47", "17"]);