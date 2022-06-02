function solve(steps, footprintInMeters, speedInKm){
    debugger;
    let distanceInMeters = steps * footprintInMeters;
    
    let timeInSeconds = (distanceInMeters / (speedInKm * 1000)) * 3600;

    let additionalTime = Math.floor(distanceInMeters / 500);

    let hours = Math.floor(timeInSeconds / 3600);
    let minutes = Math.floor(timeInSeconds / 60) + additionalTime;
    let seconds = timeInSeconds % 60;

    let result = '';
    if(hours < 10){
        result += `0${hours}:`;
        if(minutes < 10){
            result += `0${minutes}:`;
            if(seconds < 10){
                result += `0${seconds.toFixed(0)}`
            }
            else{
                result += `${seconds.toFixed(0)}`;
            }
        }
        else{
            result += `${minutes}:`;
            if(seconds < 10){
                result += `0${seconds.toFixed(0)}`
            }
            else{
                result += `${seconds.toFixed(0)}`;
            }
        }
    }
    else{
        result += `${hours}:`;
        if(minutes < 10){
            result += `0${minutes}:`;
            if(seconds < 10){
                result += `0${seconds.toFixed(0)}`
            }
            else{
                result += `${seconds.toFixed(0)}`;
            }
        }
        else{
            result += `${minutes}:`;
            if(seconds < 10){
                result += `0${seconds.toFixed(0)}`
            }
            else{
                result += `${seconds.toFixed(0)}`;
            }
        }
    }

    console.log(result);
}

solve(4000, 0.60, 5)