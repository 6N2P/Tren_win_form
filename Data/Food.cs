using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tren_win_form.Data
{
    class Food
    {
        private int id { get; set; }
        private string name { get; set; }
        private int proteins { get; set; }
        private int fats { get; set; }
        private int carbohydrates { get; set; }
        private int calories { get; set; }

        public Food() { }
        public Food(string name, int protein,int fat, int carbohydate, int calorie)
        {
            this.name = name;
            this.proteins = protein;
            this.fats = fat;
            this.carbohydrates = carbohydate;
            this.calories = calorie;
        }
    }
}
