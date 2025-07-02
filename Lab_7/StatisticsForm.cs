using Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_7
{
    public partial class StatisticsForm : Form
    {
        private readonly BusinessLogic Logic;

        public StatisticsForm(BusinessLogic logic)
        {
            InitializeComponent();
            Logic = logic;
        }

        private void SortFoodByName_Click(object sender, EventArgs e)
        {

        }
    }
}
