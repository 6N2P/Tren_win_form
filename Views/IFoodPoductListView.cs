﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tren_win_form.Views
{
    interface IFoodPoductListView

    {
        int Mass { get; set; }
        int Age { get; set; }
        int Grow { get; set; }

         event EventHandler AddProductEvent;
         event EventHandler СalorieСalculation;
         event EventHandler CalorieCalculationNorm;
    }
}
