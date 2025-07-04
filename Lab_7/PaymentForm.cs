using Logic;
using Model;

namespace Lab_7
{


    public partial class PaymentForm : Form
    {
        private readonly BusinessLogic Logic;
        public PaymentForm(Order order, BusinessLogic logic)
        {
            InitializeComponent();
            Logic = logic;
        }
    }
}
