function songs(arr){
    let songsNumber = Number(arr.shift());
    let listType = arr.pop();

    class Song{
        constructor(typeList, name, time){
            this.typeList = typeList;
            this.name = name;
            this.time = time;
        }
    }

    let songInTypeList = [];
    
    for (let i = 0; i < songsNumber; i++) {
        let songData = arr[i].split("_");

        let list = songData[0];
        let name = songData[1];
        let time = songData[2];

        if(list === listType){
            songInTypeList.push(new Song(list, name, time));
        }
        else if (listType == "all"){
            songInTypeList.push(new Song(list, name, time));
        }
    }

    for (const el of songInTypeList) {
        console.log(el.name);
    }
}

songs([3,
    'favourite_DownTown_3:14',
    'favourite_Kiss_4:16',
    'favourite_Smooth Criminal_4:01',
    'favourite']
    );