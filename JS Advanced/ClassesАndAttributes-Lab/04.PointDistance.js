class Point{
    constructor(x, y){
        this.x = x;
        this.y = y;
    }

    static distance(pointA, pointB){
        let xDistance = Math.abs(pointB.x - pointA.x);
        let yDistance = Math.abs(pointB.y - pointA.y);

        return Math.sqrt(xDistance ** 2 + yDistance ** 2);
    }
}


let p1 = new Point(5, 5);
let p2 = new Point(9, 8);
console.log(Point.distance(p1, p2));
