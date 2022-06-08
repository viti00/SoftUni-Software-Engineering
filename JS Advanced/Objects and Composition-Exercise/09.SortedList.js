function createSortedList(){
    debugger;
    let arr = [];
    let obj = {
        add(item){
            arr.push(item);
            this.size ++;
            arr = arr.sort((a,b) => a - b);
        },
        remove(index){
            if(index >= 0 && index <= arr.length -1){
                arr = arr.filter((a, i)=> i !== index);
                this.size--;
            }
            arr = arr.sort((a,b) => a - b);
        },
        get(index){
            if(index >= 0 && index <= arr.length - 1){
                return arr[index];
            }
        },
        size: 0
    }

    return obj;
}

let list = createSortedList();
list.add(5);
list.add(6);
list.add(7);
console.log(list.get(1)); 
list.remove(1);
console.log(list.get(1));
console.log(list.size);
