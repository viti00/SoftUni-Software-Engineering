function studentInformation(arg1, arg2, arg3){
    let name = arg1
    let age =Number(arg2);
    let grade =Number(arg3)

    console.log(`Name: ${name}, Age: ${age}, Grade: ${grade.toFixed(2)}`);
}

studentInformation("Velik", "21", "5.7892");