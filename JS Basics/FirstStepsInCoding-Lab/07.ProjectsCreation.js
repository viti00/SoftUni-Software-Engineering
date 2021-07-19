function projectsCreating(input){
    let architectName = input[0];
    let projectCount = input[1];
    let neededHours = projectCount * 3;

    console.log(`The architect ${architectName} will need ${neededHours} hours to complete ${projectCount} project/s.`);
}
projectsCreating(['Velik', 5]);