function getInfo() {
    let stopIdElement = document.getElementById('stopId');
    let divElement = document.getElementById('stopName');
    let ulElement = document.getElementById('buses');
    ulElement.innerHTML = '';

    let baseUrl = 'http://localhost:3030/jsonstore/bus/businfo';

    fetch(`${baseUrl}/${stopIdElement.value}`)
        .then(function(response){
            stopIdElement.value = '';
            return response.json();
        })
        .then(function(buses){
            divElement.textContent = buses.name;
            for (const key in buses.buses) {
                let liElement = document.createElement('li');
                liElement.textContent = `Bus ${key} arrives in ${buses.buses[key]} minutes`;
                ulElement.appendChild(liElement);
            }
        })
        .catch(function(){
            divElement.textContent = 'Error';
        })
}