function solve(arr){
    debugger;
    let cats = [];
    class Cat{
        constructor(name, age){
            this.name = name;
            this.age = Number(age);
        }
    }
    for (let i = 0; i < arr.length; i++) {
        let catData = arr[i].split(" ");
        let name = catData[0];
        let age = Number(catData[1]);

        cats.push(new Cat(name, age));
    }

    for (const cat of cats) {
        console.log(`${cat.name}, age ${cat.age} says Meow`);
    }
}

solve(['Mellow 2', 'Tom 5']);