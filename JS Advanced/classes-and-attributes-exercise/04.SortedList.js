class List{
    constructor(){
        this.arr = [];
        this.size = 0;
    }

    add(number){
        this.arr.push(number);
        this.arr.sort((a, b) => a - b);
        this.size++;
    }
    remove(index){
        if(index >= 0 && index < this.arr.length){
            this.arr = this.arr.filter((x, i) => i !== index);
            this.arr.sort((a, b) => a - b);
            this.size--;
        }
    }
    get(index){
        if(index >= 0 && index < this.arr.length){
            return this.arr[index];
        }
    }
}

debugger;
let list = new List();
list.add(5);
list.add(6);
list.add(7);
console.log(list.size);
console.log(list.get(1)); 
list.remove(1);
console.log(list.get(1));

