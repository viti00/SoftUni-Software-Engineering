function solve(obj){
    function createEngine(power){
        let engine = {};

        if(power <= 90){
            engine.power = 90;
            engine.volume = 1800;
        }
        else if (power > 90 && power <= 120){
            engine.power = 120;
            engine.volume = 240;
        }
        else if (power > 120 && power <= 200){
            engine.power = 200;
            engine.volume = 3500;
        }

        return engine;
    }

    function createCarriage(type, color){
        let carriage = {type, color};
        
        return carriage;
    }

    function createWheels(size){
        let realSize = size % 2 == 0 ? size - 1 : size;

        let wheels = new Array(4).fill(realSize);

        return wheels;
    }

    return {
        model: obj.model,
        engine: createEngine(obj.power),
        carriage: createCarriage(obj.carriage, obj.color),
        wheels: createWheels(obj.wheelsize)
    }
}

console.log(solve({ model: 'VW Golf II',
power: 90,
color: 'blue',
carriage: 'hatchback',
wheelsize: 14 }
))

