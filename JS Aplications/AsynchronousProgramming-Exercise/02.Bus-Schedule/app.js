function solve() {
    let departBtn = document.getElementById('depart');
    let arriveBtn = document.getElementById('arrive');

    let infoElement = document.getElementsByClassName('info')[0];

    let currStopId = 'depot';

    let baseUrl = 'http://localhost:3030/jsonstore/bus/schedule';

    function depart() {
        fetch(`${baseUrl}/${currStopId}`)
            .then(function(response){
                return response.json();
            })
            .then(function(stop){
                departBtn.disabled = true;
                arriveBtn.disabled = false;
                infoElement.textContent = `Next stop ${stop.name}`;
            })
            .catch(function(){
                infoElement.textContent = 'Error';
                departBtn.disabled = true;
                arriveBtn.disabled = true;
            })
    }

    function arrive() {
        fetch(`${baseUrl}/${currStopId}`)
            .then(function(response){
                return response.json();
            })
            .then(function(stop){
                departBtn.disabled = false;
                arriveBtn.disabled = true;
                infoElement.textContent = `Arriving at ${stop.name}`;
                currStopId = stop.next;
            })
            .catch(function(){
                infoElement.textContent = 'Error';
                departBtn.disabled = true;
                arriveBtn.disabled = true;
            })
    }

    return {
        depart,
        arrive
    };
}

let result = solve();