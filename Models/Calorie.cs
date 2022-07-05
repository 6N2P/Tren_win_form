using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tren_win_form.Models
{
   public class Calorie
    {
        public Calorie()
        {

        }
        public double CalorieCalculation(int mass, int age, int growth, double cocoefficient)
        {
            double result;
            double normMas;
            normMas = (10 * mass + 6.25 * growth - 5 * age + 5) * cocoefficient;
            result = normMas + (normMas * 0.1);
            return result;
        }
        public double CalorieCalculationNorm(int mass, int age, int growth, double cocoefficient)
        {
            double result;
            double normMas;
            normMas = (10 * mass + 6.25 * growth - 5 * age + 5) * cocoefficient;
            result = normMas;
            return result;
        }
    }
}
