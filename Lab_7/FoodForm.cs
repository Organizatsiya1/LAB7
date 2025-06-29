using Logic;
using Model;

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

            // Собираем полный путь к картинке:
            string imagesDir = Path.Combine(
                DataConverter.DataBase,   // %AppData%/…/DataBase
                "Images"
            );
            string imgPath = Path.Combine(imagesDir, food.PhotoFile ?? "");

            if (File.Exists(imgPath))
            {
                // Избегаем блокировки файла: сначала копируем в память
                using var fs = new FileStream(imgPath, FileMode.Open, FileAccess.Read);
                pictureBoxFood.Image = Image.FromStream(fs);
            }
            else
            {
                // В ресурсах проекта или просто blank
                pictureBoxFood.Image = Properties.Resources.PlaceholderMenu;
            }
        }

        private void buttonAddToCart_Click(object sender, EventArgs e)
        {
            AddToCart = true;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
