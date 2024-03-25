import { useEffect, useState } from 'react';



function DisplayForecast() {
    const [forecasts, setForecasts] = useState(null);

    useEffect(() => {
        populateWeatherData();
    }, []);

    return (
        forecasts === null ? <p>Data still hasnt fetched</p> :
            forecasts.map(forecast =>
                <tr key={forecast.date}>
                    <td>{forecast.date}</td>
                    <td>{forecast.temperatureC}</td>
                    <td>{forecast.temperatureF}</td>
                    <td>{forecast.summary}</td>
                </tr>
            )

    );

    async function populateWeatherData() {
        const response = await fetch('weatherforecast');
        const data = await response.json();
        setForecasts(data);
    }
}



export default DisplayForecast;