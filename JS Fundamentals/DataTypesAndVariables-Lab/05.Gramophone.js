function gramophone(arg1, arg2, arg3){
    debugger;
    let bandName = arg1;
    let albumName = arg2;
    let songName = arg3;

    let duration = (albumName.length * bandName.length) * songName.length / 2;

    let rotations = duration / 2.5;

    console.log(`The plate was rotated ${Math.ceil(rotations)} times.`)
}

gramophone('Black Sabbath', 'Paranoid', 'War Pigs');