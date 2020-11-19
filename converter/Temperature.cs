using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace converter
{
    class Temperature // мера тимпературы
    {
        private double temperature;

        public Temperature(double _oneVeriable)
        {
            this.temperature = _oneVeriable;
        }

        private double CelsiusFahrenheit() //Цельсий => Фаренгейт
        {
            double result = (temperature - 32) / 1.8;
            return result;
        }

        public double CelsiusFahrenheitResult
        {
            get { return CelsiusFahrenheit(); }
        }

        private double FahrenheitCelsius() //Фаренгейт => Цельсий
        {
            double result = (temperature * 1.8) + 32;
            return result;
        }

        public double FahrenheitCelsiusResult
        {
            get { return FahrenheitCelsius(); }
        }

        private double CelsiusKelvin() //Цельсий => Кельвин
        {
            double result = temperature - 273.15;
            return result;
        }

        public double CelsiusKelvinRsult
        {
            get { return CelsiusKelvin(); }
        }

        private double KelvinCelsius() //Кельвин => Цельсий
        {
            double result = temperature + 273.15;
            return result;
        }

        public double KelvinCelsiusResult
        {
            get { return KelvinCelsius(); }
        }

        private double FahrenheitKelvin() //Фаренгейт => Кельвин
        {
            double result = (temperature * 1.8) - 459.67;
            return result;
        }

        public double FahrenheitKelvinResult
        {
            get { return FahrenheitKelvin(); }
        }

        private double KelvinFahrenheit() //Кельвин => Фаренгейт
        {
            double result = (temperature + 459.67) / 1.8;
            return result;
        }

        public double KelvinFahrenheitResult
        {
            get { return KelvinFahrenheit(); }
        }
    }
}
