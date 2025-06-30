using Logic;
using Model;
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
        BusinessLogic BusinessLogic { get; set; }
        List<GroupedFood> foods = new List<GroupedFood>();
        public StatisticsForm()
        {
            InitializeComponent();

            BusinessLogic.GroupFoods(BusinessLogic.AllOrders, foods);
            dataGridView2.DataSource = foods;
        }

        private void SortFoodByName_Click(object sender, EventArgs e)
        {
            BusinessLogic.Sort_By_FoodName(foods);
        }

        private void SortFoodByNumber_Click(object sender, EventArgs e)
        {
            BusinessLogic.Sort_By_FoodCount(foods);
        }
    }
}
