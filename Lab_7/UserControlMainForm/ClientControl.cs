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
    public partial class ClientControl : UserControl
    {
        private List<Food> allFoods = new List<Food>();

        public ClientControl()
        {
            InitializeComponent();
        }

        private void textBoxClientSearch_TextChanged(object sender, EventArgs e)
        {
            string filter = textBoxClientSearch.Text.Trim().ToLower();

            // Сначала очищаем текущий лист
            listViewClientMenu.Items.Clear();

            // Перебираем все блюда и добавляем только те, у которых имя содержит подстроку filter
            foreach (var food in allFoods)
            {
                if (food.Name.ToLower().Contains(filter))
                {
                    var item = new ListViewItem(new[]
                    {
                        food.Name,
                        food.Cost.ToString("F2"),
                /* здесь можно положить путь или строку-идентификатор изображения */
            });
                    item.Tag = food; // сохраним сам объект блюда для дальнейшего использования
                                     // Назначим группу по категории:
                    switch (food.Priority)
                    {
                        case FoodCategory.Snacks:
                            item.Group = listViewClientMenu.Groups["Закуски"];
                            break;
                        case FoodCategory.Soups:
                            item.Group = listViewClientMenu.Groups["Супы"];
                            break;
                        case FoodCategory.SecondCourses:
                            item.Group = listViewClientMenu.Groups["Вторые блюда"];
                            break;
                        case FoodCategory.Desserts:
                            item.Group = listViewClientMenu.Groups["Десерты"];
                            break;
                        case FoodCategory.Drinks:
                            item.Group = listViewClientMenu.Groups["Напитки"];
                            break;
                    }
                    listViewClientMenu.Items.Add(item);
                }
            }
        }

        private void listViewClientMenu_DoubleClick(object sender, EventArgs e)
        {

        }

        private void listViewClientMenu_ItemActivate(object sender, EventArgs e)
        {

        }

        private void listViewClientCart_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {

        }

        private void buttonFormClientOrder_Click(object sender, EventArgs e)
        {

        }
    }
}
