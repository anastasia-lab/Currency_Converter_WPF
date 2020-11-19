using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace converter
{
    class Weight // мера массы
    {
        double veriable;

        public Weight(double _veriable)
        {
            this.veriable = _veriable;
        }

        private double TonKilogram() // тонна => килограмм
        {
            double result = veriable * 1000;
            return result;
        }

        public double TonKilogramResult
        {
            get { return TonKilogram(); }
        }

        private double KilogramTon() // килограмм => тонна
        {
            double result = veriable / 1000;
            return result;
        }

        public double KilogramTonResult
        {
            get { return KilogramTon(); }
        }

        private double TonGramm() // тонна => грамм
        {
            double result = 1000000 * veriable;
            return result;
        }

        public double TonGrammResult
        {
            get { return TonGramm(); }
        }

        private double GrammTon() // грамм => тонна
        {
            double resutl = veriable / 1000000;
            return resutl;
        }

        public double GrammTonResult
        {
            get { return GrammTon(); }
        }

        private double TonCenter() // тонна => центер
        {
            double result = 10 * veriable;
            return result;
        }

        public double TonCenterResult
        {
            get { return TonCenter(); }
        }

        private double CenterTon() // центер => тонна
        {
            double result = veriable / 10;
            return result;
        }

        public double CenterTonResult
        {
            get { return CenterTon(); }
        }

        private double KilogrammGramm() // килограмм => гамм
        {
            double result = veriable * 1000;
            return result;
        }

        public double KilogrammGrammResult
        {
            get { return KilogrammGramm(); }
        }

        private double GrammKilogramm() // грамм => килограмм
        {
            double result = veriable / 1000;
            return result;
        }

        public double GrammKilogrammResult
        {
            get { return GrammKilogramm(); }
        }

        private double KilogrammCenter() // килограмм => центер
        {
            double result = veriable / 100;
            return result;
        }

        public double KilogrammCenterResult
        {
            get { return KilogrammCenter(); }
        }

        private double CenterKilogramm() // центер => килограмм
        {
            double result = veriable * 100;
            return result;
        }

        public double CenterKilogrammResult
        {
            get { return CenterKilogramm(); }
        }

        private double CenterGramm() // центер => грамм
        {
            double result = veriable * 100000;
            return result;
        }

        public double CenterGrammResult
        {
            get { return CenterGramm(); }
        }

        private double GrammCente() // грамм => центер
        {
            double result = veriable / 100000;
            return result;
        }

        public double GrammCenteResult
        {
            get { return GrammCente(); }
        }
    }
}
