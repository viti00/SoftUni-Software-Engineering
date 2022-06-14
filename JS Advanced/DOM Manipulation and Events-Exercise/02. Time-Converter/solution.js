function attachEventsListeners() {

    let daysButtonElement = document.getElementById('daysBtn');
    let hoursButtonElement = document.getElementById('hoursBtn');
    let minutesButtonElement = document.getElementById('minutesBtn');
    let secondsButtonElement = document.getElementById('secondsBtn');

    let inputDays = document.getElementById('days');
    let inputHours = document.getElementById('hours');
    let inputMinutes = document.getElementById('minutes');
    let inputSeconds = document.getElementById('seconds');


    daysButtonElement.addEventListener('click', function () {
        let valueElement = inputDays.value;
        inputHours.value = valueElement * 24;
        inputMinutes.value = valueElement * 1440;
        inputSeconds.value = valueElement * 86400;
    });

    hoursButtonElement.addEventListener('click', function() {
        let valueElement = inputHours.value;
        inputDays.value = valueElement / 24;
        inputMinutes.value = valueElement * 60;
        inputSeconds.value = valueElement * 3600;
    });

    minutesButtonElement.addEventListener('click', function(){
        let valueElement = inputMinutes.value;
        inputDays.value = valueElement / 1440;
        inputHours.value = valueElement / 60;
        inputSeconds.value = valueElement * 60;
    });

    secondsButtonElement.addEventListener('click', function() {
        let valueElement = inputSeconds.value;
        inputDays.value = valueElement / 86400;
        inputHours.value = valueElement / 3600;
        inputMinutes.value = valueElement / 60;
    })
}