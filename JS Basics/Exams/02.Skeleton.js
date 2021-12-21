function skeleton(input){
    let controlTime = Number(input.shift());
    let secondsForControl = Number(input.shift());
    let lenght = Number(input.shift());

    let secondsFor100Meters = Number(input.shift());


    let controlInSeconds = controlTime * 60 + secondsForControl;

    let delayTime = (lenght / 120) * 2.5;

    let marinTime = (lenght / 100) * secondsFor100Meters - delayTime;

    if (controlInSeconds >= marinTime){
        console.log(`Marin Bangiev won an Olympic quota!`);
        console.log(`His time is ${marinTime.toFixed(3)}.`); 
    }
    else {
        let needed = marinTime - controlInSeconds;
        console.log(`No, Marin failed! He was ${needed.toFixed(3)} second slower.`);
    }
}

skeleton(["2",
"12",
"1200",
"10"])
