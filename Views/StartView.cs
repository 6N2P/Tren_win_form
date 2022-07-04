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
    public partial class StartView : Form
    {
        public StartView()
        {
            InitializeComponent();

            Presentor.Presentor presentor = new Presentor.Presentor(this);
        }

        public event EventHandler openFoodListView;

        private void buttonFood_Click(object sender, EventArgs e)
        {
            openFoodListView.Invoke(sender, e);
        }
    }
}
