using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace converter
{
    class Power // мера мощности
    {
        double veriable;
        double result;

        public Power(double _veriable)
        {
            this.veriable = _veriable;
        }

        private double WattkW() //Вт=>кВт
        {
            result = veriable / 1000;
            return result;
        }

        public double WattkWResult
        {
            get { return WattkW(); }
        }

        private double WattmW() //Вт=>мВт
        {
            result = veriable / 1000000;
            return result;
        }

        public double WattmWResult
        {
            get { return WattmW(); }
        }

        private double WattHorsepower() //Вт=>лошадиная сила
        {
            result = veriable * 0.0014;
            return result;
        }

        public double WattHorsepowerResult
        {
            get { return WattHorsepower(); }
        }

        private double kWwatt() //кВт=>Вт
        {
            result = veriable * 1000;
            return result;
        }

        public double kWwattResult
        {
            get { return kWwatt(); }
        }

        private double kWmWt() //кВт=>мВт
        {
            result = veriable / 1000;
            return result;
        }

        public double kWmWtResult
        {
            get { return kWmWt(); }
        }

        private double kWHorsepower() //кВт=>лошадиная сила
        {
            result = veriable * 1.4;
            return result;
        }

        public double kWHorsepowerResult
        {
            get { return kWHorsepower(); }
        }

        private double MWtWt() //мВт=>Вт
        {
            result = veriable * 1000000;
            return result;
        }

        public double MWtWtResult
        {
            get { return MWtWt(); }
        }

        private double MWtkWt() //мВт=>кВт
        {
            result = veriable * 1000;
            return result;
        }

        public double MWtkWtResult
        {
            get { return MWtkWt(); }
        }

        private double MWtHorsepower() //мВт=>лошадиная сила
        {
            result = veriable * (1.35962 * 1000);
            return result;
        }

        public double MWtHorsepowerResult
        {
            get { return MWtHorsepower(); }
        }

        private double HorsepowerWt() //лошадиная сила=>Вт
        {
            result = veriable * 735.5;
            return result;
        }

        public double HorsepowerWtResult
        {
            get { return HorsepowerWt(); }
        }

        private double HorsepowerkWt() //лошадиная сила=>kВт
        {
            result = veriable * (735.5 * 0.001);
            return result;
        }

        public double HorsepowerkWtResult
        {
            get { return HorsepowerkWt(); }
        }

        private double HorsepowermWt() //лошадиная сила=>мВт
        {
            result = veriable * (735.5 * Math.Pow(10, (-6)));
            return result;
        }

        public double HorsepowermWtResult
        {
            get { return HorsepowermWt(); }
        }
    }
}
