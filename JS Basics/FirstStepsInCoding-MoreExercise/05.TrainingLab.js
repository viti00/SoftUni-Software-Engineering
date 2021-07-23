function calculateWorkPlaces(input){
    let lenght = Number(input[0]);
    let width = Number(input[1]);

    let deskCount = parseInt(((width * 100) - 100)/ 70);

    let rows = parseInt((lenght * 100) / 120);

    let workPlaces = deskCount * rows - 3;

    console.log(workPlaces);
}

calculateWorkPlaces(["15", "8.9"])