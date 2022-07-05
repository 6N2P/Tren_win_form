using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tren_win_form.Presentor;

namespace Tren_win_form.Views
{
    public partial class FoodProductListView : Form
    {
        public FoodProductListView()
        {
            InitializeComponent();
            Presentor.Presentor presentor = new Presentor.Presentor(this);

        }

        public event EventHandler AddProductEvent;
        public event EventHandler СalorieСalculation;
        public event EventHandler CalorieCalculationNorm;

        private void AddProductButton_Click(object sender, EventArgs e)
        {
            AddProductEvent.Invoke(sender, e);
        }

        private void CalculatedCaloriesLabel_Click(object sender, EventArgs e)
        {
            СalorieСalculation.Invoke(sender, e);
        }

        private void caloriNormLabel_Click(object sender, EventArgs e)
        {
            CalorieCalculationNorm.Invoke(sender, e);
        }
    }
}
