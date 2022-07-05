using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tren_win_form.Views;
using Tren_win_form.Models;

 namespace Tren_win_form.Presentor
{

   
  public  class Presentor
    {
        StartView startView1;
        FoodProductListView foodProductListView;
        AddProductView addProductVie;
        Calorie calorieCalc;
        
        public Presentor(StartView startView)
        {
            startView1 = startView;
            startView1.openFoodListView += StartView1_openFoodListView;
        }

        public Presentor(FoodProductListView foodProductList)
        {
            foodProductListView = foodProductList;
            foodProductListView.AddProductEvent += FoodProductListView_AddProductEent;
            foodProductListView.СalorieСalculation += FoodProductListView_СalorieСalculation;
            foodProductListView.CalorieCalculationNorm += FoodProductListView_CalorieCalculationNorm;
        }

        private void FoodProductListView_CalorieCalculationNorm(object sender, EventArgs e)
        {
            double coaficient = 0;


            int item = foodProductListView.coaficComboBox.SelectedIndex;
            coaficient = 1;
            switch (item)
            {
                case 0:
                    coaficient = 1.2;
                    break;
                case 1:
                    coaficient = 1.375;
                    break;
                case 2:
                    coaficient = 1.55;
                    break;
                case 3:
                    coaficient = 1.725;
                    break;
                case 4:
                    coaficient = 1.9;
                    break;
            }

            int mass;
            if (foodProductListView.massTextBox.Text != "")
            {
                mass = Convert.ToInt32(foodProductListView.massTextBox.Text);
            }
            else
            {
                mass = 0;
            }

            int age;
            if (foodProductListView.ageTextBox.Text != "")
            {
                age = Convert.ToInt32(foodProductListView.ageTextBox.Text);
            }
            else
            {
                age = 0;
            }
            int grow;
            if (foodProductListView.growTextBox.Text != "")
            {
                grow = Convert.ToInt32(foodProductListView.growTextBox.Text);
            }
            else
            {
                grow = 0;
            }
            calorieCalc = new Calorie();
            foodProductListView.caloriNormLabel.Text =
                calorieCalc.CalorieCalculationNorm(mass, age, grow, coaficient).ToString();
        }

        private void FoodProductListView_СalorieСalculation(object sender, EventArgs e)
        {
            double coaficient=0;


            int item = foodProductListView.coaficComboBox.SelectedIndex;
            coaficient = 1;
            switch (item)
            {
                case 0:
                    coaficient = 1.2;
                    break;
                case 1:
                    coaficient = 1.375;
                    break;
                case 2:
                    coaficient = 1.55;
                    break;
                case 3:
                    coaficient = 1.725;
                    break;
                case 4:
                    coaficient = 1.9;
                    break;
            }

            int mass;
            if (foodProductListView.massTextBox.Text != "")
            {
                mass = Convert.ToInt32(foodProductListView.massTextBox.Text);
            }
            else
            {
                mass = 0;
            }

            int age;
            if (foodProductListView.ageTextBox.Text != "")
            {
              age= Convert.ToInt32(foodProductListView.ageTextBox.Text);
            }
            else
            {
                age = 0;
            }
            int grow;
            if (foodProductListView.growTextBox.Text != "")
            {
              grow= Convert.ToInt32(foodProductListView.growTextBox.Text);
            }
            else
            {
                grow = 0;
            }
            calorieCalc = new Calorie();
            foodProductListView.calculatedCaloriesLabel.Text =
                calorieCalc.CalorieCalculation(mass, age, grow, coaficient).ToString();

        }

        private void FoodProductListView_AddProductEent(object sender, EventArgs e)
        {
            addProductVie = new AddProductView();
            addProductVie.Show();
        }

        private void StartView1_openFoodListView(object sender, EventArgs e)
        {
            foodProductListView = new FoodProductListView();
            foodProductListView.Show();
        }
    }
}
