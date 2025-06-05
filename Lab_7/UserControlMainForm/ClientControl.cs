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
    public partial class ClientControl : UserControl
    {
        // Список всех блюд (меню)
        private List<Food> allFoods = new List<Food>();

        // Корзина клиента > просто List<Food> (каждый раз кладём один экземпляр)
        private List<Food> cartFoods = new List<Food>();

        // Текущий клиент
        private Client currentClient;

        public ClientControl()
        {
            InitializeComponent();

            allFoods = BusinessLogic.Foods.ToList();

            // Сразу заполняем всё меню
            PopulateMenu(allFoods);

            // Изначально «Итого» = 0
            UpdateTotalPrice();

        }

        /// <summary>
        /// Заполняет список меню переданным списком блюд (без учёта корзины)
        /// </summary>
        private void PopulateMenu(List<Food> foods)
        {
            listViewClientMenu.Items.Clear();

            foreach (var food in foods)
            {
                var item = new ListViewItem(new[]
                {
                    food.Name,
                    food.Cost.ToString(),
                    "" // сюда можно подставить путь/ID картинки, если будет
                });
                item.Tag = food;

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

        /// <summary>
        /// При вводе текста в поле поиска фильтруем и обновляем меню
        /// </summary>
        private void textBoxClientSearch_TextChanged(object sender, EventArgs e)
        {
            string filter = textBoxClientSearch.Text.Trim().ToLower();
            var filtered = string.IsNullOrEmpty(filter)
                ? allFoods.ToList()
                : allFoods.Where(f => f.Name.ToLower().Contains(filter)).ToList();

            PopulateMenu(filtered);
        }

        /// <summary>
        /// Двойной клик по элементу меню — добавляем его в корзину
        /// </summary>
        private void listViewClientMenu_DoubleClick(object sender, EventArgs e)
        {
            if (listViewClientMenu.SelectedItems.Count == 0)
                return;

            var sel = listViewClientMenu.SelectedItems[0];
            var food = (Food)sel.Tag;

            cartFoods.Add(food);
            RefreshCartListView();
            UpdateTotalPrice();
        }

        /// <summary>
        /// Обновляет отображение корзины, группируя корзину по Id (или по Name)
        /// </summary>
        private void RefreshCartListView()
        {
            listViewClientCart.Items.Clear();

            // Группируем по ID, чтобы понять, сколько штук каждого блюда
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
                listViewClientCart.Items.Add(item);
            }
        }

        /// <summary>
        /// Пересчитывает и отображает общую сумму корзины
        /// </summary>
        private void UpdateTotalPrice()
        {
            double total = cartFoods.Sum(f => f.Cost);
            labelClientTotalPrice.Text = $"Итого:   \t{total:F2} руб.";
        }


        /// <summary>
        /// При переключении вкладки: если это «Текущий заказ», заполняем его данными
        /// </summary>
        private void TabControlClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControlClient.SelectedTab == tabPageClientCurrentOrder)
            {
                listViewClientCurrentOrder.Items.Clear();

                if (currentClient == null)
                    return;

                var order = new BusinessLogic().GetCurrentOrderForClient(currentClient);
                if (order == null)
                    return;

                // Для каждого блюда в order.Foods ставим «В процессе» или «Готово»
                foreach (var food in order.Foods)
                {
                    var status = order.Behavior >= OrderBehavior.Coocked ? "Готово" : "В процессе";
                    var item = new ListViewItem(new[] { food.Name, status });
                    listViewClientCurrentOrder.Items.Add(item);
                }
            }
        }

        /// <summary>
        /// Метод для передачи в этот контрол текущего клиента (вызывается после входа)
        /// </summary>
        public void SetClient(Client client)
        {
            currentClient = client;
        }
    }
}
