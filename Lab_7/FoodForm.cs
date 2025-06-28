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
    public partial class FoodForm : Form
    {
        private readonly Food _food;

        /// <summary>
        /// Будет true, если пользователь нажал кнопку "Добавить в корзину"
        /// </summary>
        public bool AddToCart { get; private set; } = false;

        public FoodForm(Food food)
        {
            InitializeComponent();
            _food = food;

            labelName.Text = food.Name;
            labelDescription.Text = food.Description;
            textBoxDescription.Text = $"{string.Join(", ", food.Formula)}";
            labelWeight.Text = $"{food.Weight} г";
            labelCost.Text = $"{food.Cost} руб.";
            // pictureBoxFood.Image = Image.FromFile(food.PhotoPath);
        }

        private void buttonAddToCart_Click(object sender, EventArgs e)
        {
            AddToCart = true;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
