using System;
using System.Collections.Generic;

namespace Test_Project.Services
{
    public interface IWeatherForcastService
    {

        public IEnumerable<WeatherForecast> RandomWetherForcasts { get; }
    }
}

