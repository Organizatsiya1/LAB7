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
            if (CurrentOrder is DeliveredOrder)
            {
                TypeLabe.Text = "Доставка";
            }
            CostLabe.Text = CurrentOrder.Cost.ToString();
            BehaviourLabe.Text = CurrentOrder.Behavior.ToString();
            PayementLabe.Text = "Не оплачено";
            if(CurrentOrder.IsPayed == true)
            {
                PayementLabe.Text = "Оплачено";
            }
        }
        

        
    }
}
