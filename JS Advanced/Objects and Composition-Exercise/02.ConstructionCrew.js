function solve(input){
    debugger;
    const obj = input;
    const keys = Object.keys(obj);

    const isDizziness = obj[keys[3]];

    if(isDizziness){
        obj[keys[2]] += 0.1 * obj[keys[0]] * obj[keys[1]];
        obj[keys[3]] = false;
    }


    return obj;
}

console.log(solve({ weight: 80,
    experience: 1,
    levelOfHydrated: 0,
    dizziness: true }
  ))