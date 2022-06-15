function solve(area, vol, input) {
    debugger;
    let xyzValues = JSON.parse(input);
    let arr = [];
    
    for (const xyzValue of xyzValues) {
        arr.push({
            area: area.call(xyzValue),
            volume: vol.call(xyzValue)
        });
    }

    return arr;
}


function area() {
    return Math.abs(this.x * this.y);
};


function vol() {
    return Math.abs(this.x * this.y * this.z);
};


solve(area, vol, `[
    {"x":"1","y":"2","z":"10"},
    {"x":"7","y":"7","z":"10"},
    {"x":"5","y":"2","z":"10"}
    ]`
    )