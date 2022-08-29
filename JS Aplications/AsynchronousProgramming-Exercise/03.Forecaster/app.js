function attachEvents() {

    let getWeatherBtn = document.getElementById('submit');
    let locationElement = document.getElementById('location');
    let forecastElement = document.getElementById('forecast');
    let todayWeather = document.getElementById('current');
    let upcommingWeather = document.getElementById('upcoming');

    getWeatherBtn.addEventListener('click', getWeather)

    function getWeather() {
        forecastElement.style.display = 'block';
        let baseUrl = 'http://localhost:3030/jsonstore/forecaster';
        Array.from(forecastElement.querySelectorAll('div')).forEach((el, i) => {
            i === 5 ? el.remove() : el;
        })
        Array.from(todayWeather.querySelectorAll('div')).forEach((el, i) => {
            i !== 0 ? el.remove() : el;
        })
        Array.from(upcommingWeather.querySelectorAll('div')).forEach((el, i) => {
            i !== 0 ? el.remove() : el;
        })

        fetch(`${baseUrl}/locations`)
            .then(function (response) {
                return response.json();
            })
            .then(function (cities) {
                let city = cities.find(x => x.name == locationElement.value);
                let cityCode = city.code;

                fetch(`${baseUrl}/today/${cityCode}`)
                    .then(response => response.json())
                    .then(forecast => {
                        let currWeather = createCurrentWeather(forecast)
                        todayWeather.appendChild(currWeather);
        
                       
                    })
                fetch(`${baseUrl}/upcoming/${cityCode}`)
                .then(response => response.json())
                .then(upcomingWeatherCondition => {
                    debugger;
                    let upcomingWeatherCond = createUpcomingElement(upcomingWeatherCondition);
                    upcommingWeather.appendChild(upcomingWeatherCond);
    
                })

            })
            
            .catch(function (error) {
                let div = document.createElement('div');
                
                let divError = document.createElement('div');
                divError.setAttribute('class', 'label');
                divError.textContent = "Error";

                div.appendChild(divError);

                forecastElement.appendChild(div);
            })
    }

    function createUpcomingElement(upcomingWeatherCondition) {
        let divForecast = document.createElement('div');
        divForecast.setAttribute('class', 'forecast-info');

        for (const weather of upcomingWeatherCondition.forecast) {
            let { condition, low, high } = weather;

            let spanUpcomingElement = document.createElement('span');
            spanUpcomingElement.setAttribute('class', 'upcoming');

            let conditionSymbolSpanElement = document.createElement('span');
            conditionSymbolSpanElement.setAttribute('class', 'forecast-data');
            conditionSymbolSpanElement.textContent = getWeatherSymbol(condition);

            let temperatureSpanElement = document.createElement('span');
            temperatureSpanElement.setAttribute('class', 'forecast-data');
            temperatureSpanElement.textContent = `${low}°/${high}°`;

            let conditionTextSpanElement = document.createElement('span');
            conditionTextSpanElement.setAttribute('class', 'forecast-data');
            conditionTextSpanElement.textContent = condition;

            spanUpcomingElement.appendChild(conditionSymbolSpanElement);
            spanUpcomingElement.appendChild(temperatureSpanElement);
            spanUpcomingElement.appendChild(conditionTextSpanElement);

            divForecast.appendChild(spanUpcomingElement);

        }

        return divForecast;
    }

    function createCurrentWeather(forecast) {

        debugger;
        let { condition, high, low } = forecast.forecast;

        let forecastDivElement = document.createElement('div');
        forecastDivElement.setAttribute('class', 'forecasts');

        let spanElement = document.createElement('span');
        spanElement.setAttribute('class', 'condition');

        let condtionSymbolSpanElement = document.createElement('span');
        condtionSymbolSpanElement.setAttribute('class', 'condition symbol')
        let symbol = getWeatherSymbol(condition);
        condtionSymbolSpanElement.textContent = symbol;

        let cityNameSpanElement = document.createElement('span');
        cityNameSpanElement.setAttribute('class', 'forecast-data');
        cityNameSpanElement.textContent = forecast.name;

        let temperatureSpanElement = document.createElement('span');
        temperatureSpanElement.setAttribute('class', 'forecast-data');
        temperatureSpanElement.textContent = `${low}°${high}°`;

        let condtionNameSpanElement = document.createElement('span');
        condtionNameSpanElement.setAttribute('class', 'forecast-data');
        condtionNameSpanElement.textContent = condition;

        spanElement.appendChild(cityNameSpanElement);
        spanElement.appendChild(temperatureSpanElement);
        spanElement.appendChild(condtionNameSpanElement);

        forecastDivElement.appendChild(condtionSymbolSpanElement);
        forecastDivElement.appendChild(spanElement);

        return forecastDivElement;
    }

    function getWeatherSymbol(condition) {
        let symbol = '';
        if (condition == 'Sunny') {
            symbol = "☀";
        }
        else if (condition == 'Partly sunny') {
            symbol = "⛅";
        }
        else if (condition == 'Overcast') {
            symbol = "☁";
        }
        else if (condition == 'Rain') {
            symbol = "☂";
        }

        return symbol;
    }
}



attachEvents();