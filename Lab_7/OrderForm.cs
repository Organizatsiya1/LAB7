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
        public OrderForm CurrentOrder { get; set; }
        public OrderForm(OrderForm order)
        {
            InitializeComponent();
            CurrentOrder = order;
            //приписать привязки по данным на надписи
        }



    }
}
