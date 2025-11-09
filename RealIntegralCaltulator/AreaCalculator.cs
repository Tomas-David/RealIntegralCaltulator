using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealIntegralCaltulator
{
    internal class AreaCalculator
    {
        private double _n { get; set; }
        private double _a { get; set; }
        private double _b { get; set; }
        private double _step { get; set; }

        public AreaCalculator(double n, double a, double b, double step )
        {
            _n = n;
            _a = a;
            _b = b;
            _step = step;
        }

        public double CalculateArea()
        {
            
            if (Math.Abs(_n + 1.0) < 1e-12)
            {
                
                if (_a == 0.0 || _b == 0.0)
                    throw new InvalidOperationException("Nelze integrovat 1/x přes 0.");
                return Math.Log(Math.Abs(_b)) - Math.Log(Math.Abs(_a));
            }
            else
            {
                double p = _n + 1.0;
                return (Math.Pow(_b, p) - Math.Pow(_a, p)) / p;
            }
        }


        public double CalculateLowerSum(Func<double, double> f)
        {
            double sum = 0.0;
            for (double x = _a; x < _b; x += _step)
            {
                double minVal = Math.Min(f(x), f(x + _step));
                sum += minVal * _step;
            }
            return sum;
        }

        public double CalculateUpperSum(Func<double, double> f)
        {
            double sum = 0.0;
            for (double x = _a; x < _b; x += _step)
            {
                double maxVal = Math.Max(f(x), f(x + _step));
                sum += maxVal * _step;
            }
            return sum;
        }

        public (double min, double max) FindMinMax(Func<double, double> f)
        {
            double min = double.PositiveInfinity;
            double max = double.NegativeInfinity;

            for (double x = _a; x <= _b; x += _step)
            {
                double y = f(x);
                if (y < min) min = y;
                if (y > max) max = y;
            }

            return (min, max);
        }


        public override string ToString()
        {
            
            Func<double, double> f = x => Math.Pow(x, _n);

            
            double exact = CalculateArea();
            double lower = CalculateLowerSum(f);
            double upper = CalculateUpperSum(f);
            var (min, max) = FindMinMax(f);

            return
                $"--------------------------------------\n" +
                $" Výpočet určitého integrálu f(x)=x^{_n}\n" +
                $"--------------------------------------\n" +
                $"Interval:            <{_a}; {_b}>\n" +
                $"Krok dělení (step):  {_step}\n\n" +
                $"PŘESNÁ PLOCHA:       {exact}\n" +
                $"Dolní součet:        {lower}\n" +
                $"Horní součet:        {upper}\n" +
                $"Rozdíl (horní-dolní): {upper - lower}\n\n" +
                $"Minimum f(x) na intervalu: {min}\n" +
                $"Maximum f(x) na intervalu: {max}\n" +
                $"--------------------------------------";
        }
    }
}
