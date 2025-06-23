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
    public partial class OrderForm : Form
    {
        // Текущий заказ, отображаемый в форме.
        public Order CurrentOrder { get; set; }

        /// <summary>
        /// Заполняет элементы интерфейса данными заказа.
        /// </summary>
        /// <param name="order">Объект заказа, который будет отображён в форме</param>
        public OrderForm(Order order)
        {
            InitializeComponent();
            CurrentOrder = order;

            OrderIDLabe.Text = $"ID: {CurrentOrder.Id}";
            DateLabe.Text = order.Date.ToString("dd.MM.yyyy HH:mm");
            if (CurrentOrder is DeliveredOrder)
            {
                TypeLabe.Text = "Доставка";
            }
            CostLabe.Text = CurrentOrder.Cost.ToString();
            BehaviourLabe.Text = CurrentOrder.Behavior.ToString();
            PayementLabe.Text = "Не оплачено";
            if (CurrentOrder.IsPayed == true)
            {
                PayementLabe.Text = "Оплачено";
            }

            // Стоимость — суммируем в форме
            var total = order.Foods.Sum(f => f.Cost);
            CostLabe.Text = $"{total:F2} руб.";

            // Заполняем таблицу: каждый тип блюда с количеством
            var counts = order.Foods
                .GroupBy(f => f.Name)
                .Select(g => (Name: g.Key, Qty: g.Count()));
            foreach (var (Name, Qty) in counts)
                FoodsGrid.Rows.Add(Name, Qty);
        }
    }
}
