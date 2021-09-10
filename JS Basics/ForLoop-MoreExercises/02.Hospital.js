function hospital(input){
    let n = Number(input.shift());
    
    let treatedPatients = 0;
    let untreatedPatients = 0;

    let doctorsCount = 7;
    let count = 0;

    for (let index = 0; index < n; index++) {
        count++;
        if (count % 3 == 0){
            if (treatedPatients < untreatedPatients){
                doctorsCount ++;
            }
        }
        let patients = Number(input[index]);
        if(patients > doctorsCount){
            treatedPatients += doctorsCount;
            untreatedPatients += patients -  doctorsCount;
        }
        else{
            treatedPatients += patients;
        }
    }

    console.log(`Treated patients: ${treatedPatients}.`);
    console.log(`Untreated patients: ${untreatedPatients}.`)
}

hospital(["4", "7", "27", "9", "1"]);