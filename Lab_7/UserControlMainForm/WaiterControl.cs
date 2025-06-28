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
    public partial class WaiterControl : UserControl
    {
        private readonly Client currentClient;      // Текущий клиент
        private readonly BusinessLogic logic = new BusinessLogic();
        private List<Food> allFoods = new List<Food>();   // Список всех блюд (меню)
        private List<Food> cartFoods = new List<Food>();  // Корзина клиента

        /// <summary>
        /// При создании этот конструктор получает объект Client и сохраняет его во внутреннем поле
        /// Затем загружает меню и подписывает обработчик для кнопки "«Профиль»"
        /// </summary>
        /// <param name="clientFromLogin">Объект Client, соответствующий вошедшему пользователю</param>
        public WaiterControl(Client clientFromLogin)
        {
            InitializeComponent();

            currentClient = clientFromLogin;

            // Загружаем меню из статического списка BusinessLogic.Foods
            allFoods = BusinessLogic.Foods.ToList();

            // Заполняем ListView блюдами
            PopulateMenu(allFoods);

            // Счетчик «Итого» = 0
            UpdateTotalPrice();
        }

        /// <summary>
        /// Заполняет список меню передачными блюдами (без учёта корзины)
        /// </summary>
        /// <param name="foods">Список Food для отображения</param>
        private void PopulateMenu(List<Food> foods)
        {
            listViewWaiterMenu.Items.Clear();

            foreach (var food in foods)
            {
                var item = new ListViewItem(new[]
                {
                    food.Name,
                    food.Cost.ToString(),
                    "" // здесь можно добавить путь/название картинки
                });
                item.Tag = food;

                switch (food.Priority)
                {
                    case FoodCategory.Entree:
                        item.Group = listViewWaiterMenu.Groups["Закуски"];
                        break;
                    case FoodCategory.MainCourse:
                        item.Group = listViewWaiterMenu.Groups["Супы"];
                        break;
                    case FoodCategory.Entremets:
                        item.Group = listViewWaiterMenu.Groups["Вторые блюда"];
                        break;
                    case FoodCategory.Desserts:
                        item.Group = listViewWaiterMenu.Groups["Десерты"];
                        break;
                    case FoodCategory.Digestif:
                        item.Group = listViewWaiterMenu.Groups["Напитки"];
                        break;
                }

                listViewWaiterMenu.Items.Add(item);
            }
        }

        /// <summary>
        /// Фильтрует меню по введённому названию
        /// </summary>
        /// <param name="sender">Ссылка на TextBox с поиском</param>
        /// <param name="e">Аргументы события</param>
        private void textBoxClientSearch_TextChanged(object sender, EventArgs e)
        {
            string filter = textBoxWaiterSearch.Text.Trim().ToLower();
            var filtered = string.IsNullOrEmpty(filter)
                ? allFoods.ToList()
                : allFoods.Where(f => f.Name.ToLower().Contains(filter)).ToList();

            PopulateMenu(filtered);
        }

        /// <summary>
        /// Добавляет выбранное блюдо в корзину
        /// </summary>
        /// <param name="sender">Ссылка на ListView с меню</param>
        /// <param name="e">Аргументы события</param>
        private void listViewClientMenu_DoubleClick(object sender, EventArgs e)
        {
            if (listViewWaiterMenu.SelectedItems.Count == 0)
                return;

            var sel = listViewWaiterMenu.SelectedItems[0];
            var food = (Food)sel.Tag;

            cartFoods.Add(food);
            RefreshCartListView();
            UpdateTotalPrice();
        }

        /// <summary>
        /// Обновляет отображение корзины: группирует по Id блюда и показывает
        /// количество и общую сумму по каждому виду
        /// </summary>
        private void RefreshCartListView()
        {
            listViewWaiterCart.Items.Clear();

            var grouped = cartFoods
                .GroupBy(f => f.Id)
                .Select(g => new
                {
                    Dish = g.First(),
                    Quantity = g.Count(),
                    Sum = g.Sum(x => x.Cost)
                });

            foreach (var entry in grouped)
            {
                var item = new ListViewItem(new[]
                {
                    entry.Dish.Name,
                    entry.Quantity.ToString(),
                    entry.Sum.ToString("F2")
                });
                item.Tag = entry.Dish;
                listViewWaiterCart.Items.Add(item);
            }
        }

        /// <summary>
        /// Пересчитывает и отображает общую сумму корзины в метке "Итого" на форме
        /// </summary>
        private void UpdateTotalPrice()
        {
            double total = cartFoods.Sum(f => f.Cost);
            labelWaiterTotalPrice.Text = $"Итого:   \t{total:F2} руб.";
        }

        /// <summary>
        /// Если выбрана вкладка "«Текущий заказ»",
        /// заполняет список готовности блюд данными из последнего «открытого» заказа клиента (кнопка формирования заказа!)
        /// </summary>
        /// <param name="sender">Ссылка на TabControl</param>
        /// <param name="e">Аргументы события</param>
        private void TabControlClient_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Открывает ProfileForm для текущего клиента по нажатию на кнопку "«Профиль»"
        /// </summary>
        /// <param name="sender">Ссылка на кнопку "«Профиль»"</param>
        /// <param name="e">Аргументы события</param>
        private void ButtonClientProfile_Click(object sender, EventArgs e)
        {
            // currentClient гарантированно не null, потому что мы передали его в конструкторе
            using (var profileForm = new ProfileForm(currentClient))
            {
                profileForm.ShowDialog();
            }
        }

        /// <summary>
        /// Закрывает окно для текущего клиента после нажатия кнопки "Выход" и открывает LoginForm
        /// </summary>
        /// <param name="sender">Ссылка на кнопку "Выход"</param>
        /// <param name="e">Аргументы события</param>
        private void buttonWaiterLogout_Click(object sender, EventArgs e)
        {
            // Скрываем текущее окно
            var currentForm = this.FindForm();
            currentForm.Hide();

            // Открываем форму входа
            var loginForm = new LoginForm();
            loginForm.Show();

            // Закрываем окно после открытия loginForm
            currentForm.Close();
        }
    }
}
