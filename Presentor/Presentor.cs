using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tren_win_form.Views;

 namespace Tren_win_form.Presentor
{

   
  public  class Presentor
    {
        StartView startView1;
        FoodProductListView foodProductListView;
        AddProductView addProductVie;
        public Presentor(StartView startView)
        {
            startView1 = startView;
            startView1.openFoodListView += StartView1_openFoodListView;
        }

        public Presentor(FoodProductListView foodProductList)
        {
            foodProductListView = foodProductList;
            foodProductListView.AddProductEvent += FoodProductListView_AddProductEent;
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
