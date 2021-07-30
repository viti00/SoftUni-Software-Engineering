function pipes(input){
    let v = Number(input[0]);

    let pipeA = Number(input[1]);

    let pipeB = Number(input[2]);

    let workerMissingHours = Number(input[3]);

    let volume = pipeA * workerMissingHours + pipeB * workerMissingHours;

    let pipeAPercent = (workerMissingHours * pipeA) / volume;

    let pipeBPercent = (workerMissingHours * pipeB) / volume;

    if(v < volume){
        let overflow = volume - v;
        console.log(`For ${workerMissingHours} hours the pool overflows with ${overflow.toFixed(2)} liters.`);
    }
    else {
        let volumePercent = volume / v;
        console.log(`The pool is ${(volumePercent * 100).toFixed(2)}% full. Pipe 1: ${(pipeAPercent * 100).toFixed(2)}%. Pipe 2: ${(pipeBPercent * 100).toFixed(2)}%.`);
    }
}

pipes(["1000", "100", "120", "3"]);