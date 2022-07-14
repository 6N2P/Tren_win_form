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
    public partial class FoodProductListView : Form, IFoodPoductListView
    {
        public FoodProductListView()
        {
            InitializeComponent();
            Presentor.Presentor presentor = new Presentor.Presentor(this);

        }
        public int Mass
        {
            get
            {
                if (massTextBox.Text != "")
                {
                    return int.Parse(massTextBox.Text);
                }
                else {return 0;}
            }
        
            set { massTextBox.Text = value.ToString(); }
        }
        public int Age
        {
            get
            {
                if (ageTextBox.Text != "")
                {
                   return int.Parse(ageTextBox.Text);
                }
                else { return 0; }
            } 
            set => ageTextBox.Text = value.ToString();
        }
        public int Grow
        {
            get
            { 
                if (growTextBox.Text!="")
                {
                   return int.Parse(growTextBox.Text);
                }
                else { return 0; }
                
            }
            set => growTextBox.Text = value.ToString();
        }
        public int Coafic
        {
            get => coaficComboBox.SelectedIndex;
            set => coaficComboBox.SelectedIndex = value;
        }
        public string CaloriNormal
        {
            get => caloriNormLabel.Text;
            set => caloriNormLabel.Text = value;
        }
        public string CaloriCalculaet
        {
            get => calculatedCaloriesLabel.Text;
            set => calculatedCaloriesLabel.Text = value;
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
