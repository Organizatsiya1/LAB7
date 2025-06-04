namespace Lab_7
{
    partial class ClientControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            ListViewGroup listViewGroup11 = new ListViewGroup("GroupSnacks", HorizontalAlignment.Left);
            ListViewGroup listViewGroup12 = new ListViewGroup("GroupSoups", HorizontalAlignment.Left);
            ListViewGroup listViewGroup13 = new ListViewGroup("GroupSecondCourses", HorizontalAlignment.Left);
            ListViewGroup listViewGroup14 = new ListViewGroup("GroupDesserts", HorizontalAlignment.Left);
            ListViewGroup listViewGroup15 = new ListViewGroup("GroupDrinks", HorizontalAlignment.Left);
            ListViewItem listViewItem5 = new ListViewItem("Закуски");
            ListViewItem listViewItem6 = new ListViewItem("Супы");
            tabControlClient = new TabControl();
            tabPageClientMenu = new TabPage();
            buttonFormClientOrder = new Button();
            labelClientTotalPrice = new Label();
            listViewClientCart = new ListView();
            columnNameDish = new ColumnHeader();
            columnCountDishCart = new ColumnHeader();
            columnSum = new ColumnHeader();
            textBoxClientSearch = new TextBox();
            listViewClientMenu = new ListView();
            columnNameDishMenu = new ColumnHeader();
            columnPriceDish = new ColumnHeader();
            columnPictureDish = new ColumnHeader();
            panel1 = new Panel();
            button1 = new Button();
            pictureBoxIcon = new PictureBox();
            tabPageClientCurrentOrder = new TabPage();
            listViewClientCurrentOrder = new ListView();
            columnNameDishCurrentOrder = new ColumnHeader();
            columnStatus = new ColumnHeader();
            tabControlClient.SuspendLayout();
            tabPageClientMenu.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxIcon).BeginInit();
            tabPageClientCurrentOrder.SuspendLayout();
            SuspendLayout();
            // 
            // tabControlClient
            // 
            tabControlClient.Controls.Add(tabPageClientMenu);
            tabControlClient.Controls.Add(tabPageClientCurrentOrder);
            tabControlClient.Location = new Point(150, 0);
            tabControlClient.Name = "tabControlClient";
            tabControlClient.SelectedIndex = 0;
            tabControlClient.Size = new Size(944, 700);
            tabControlClient.TabIndex = 1;
            // 
            // tabPageClientMenu
            // 
            tabPageClientMenu.BackColor = Color.FromArgb(99, 58, 52);
            tabPageClientMenu.Controls.Add(buttonFormClientOrder);
            tabPageClientMenu.Controls.Add(labelClientTotalPrice);
            tabPageClientMenu.Controls.Add(listViewClientCart);
            tabPageClientMenu.Controls.Add(textBoxClientSearch);
            tabPageClientMenu.Controls.Add(listViewClientMenu);
            tabPageClientMenu.Cursor = Cursors.Hand;
            tabPageClientMenu.Location = new Point(4, 29);
            tabPageClientMenu.Name = "tabPageClientMenu";
            tabPageClientMenu.Padding = new Padding(3);
            tabPageClientMenu.Size = new Size(936, 667);
            tabPageClientMenu.TabIndex = 0;
            tabPageClientMenu.Text = "Меню";
            // 
            // buttonFormClientOrder
            // 
            buttonFormClientOrder.Cursor = Cursors.Hand;
            buttonFormClientOrder.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonFormClientOrder.ForeColor = SystemColors.ControlLightLight;
            buttonFormClientOrder.Location = new Point(515, 599);
            buttonFormClientOrder.Name = "buttonFormClientOrder";
            buttonFormClientOrder.Size = new Size(415, 62);
            buttonFormClientOrder.TabIndex = 4;
            buttonFormClientOrder.Text = "Сделать заказ";
            buttonFormClientOrder.UseVisualStyleBackColor = false;
            // 
            // labelClientTotalPrice
            // 
            labelClientTotalPrice.AutoSize = true;
            labelClientTotalPrice.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelClientTotalPrice.ForeColor = SystemColors.ControlLightLight;
            labelClientTotalPrice.Location = new Point(515, 556);
            labelClientTotalPrice.Name = "labelClientTotalPrice";
            labelClientTotalPrice.Size = new Size(91, 31);
            labelClientTotalPrice.TabIndex = 3;
            labelClientTotalPrice.Text = "Итого: ";
            // 
            // listViewClientCart
            // 
            listViewClientCart.BackColor = Color.FromArgb(234, 215, 209);
            listViewClientCart.Columns.AddRange(new ColumnHeader[] { columnNameDish, columnCountDishCart, columnSum });
            listViewClientCart.Location = new Point(515, 42);
            listViewClientCart.Name = "listViewClientCart";
            listViewClientCart.Size = new Size(415, 502);
            listViewClientCart.TabIndex = 2;
            listViewClientCart.UseCompatibleStateImageBehavior = false;
            listViewClientCart.View = View.Details;
            // 
            // columnNameDish
            // 
            columnNameDish.Text = "Название";
            columnNameDish.Width = 160;
            // 
            // columnCountDishCart
            // 
            columnCountDishCart.Text = "Кол-во";
            columnCountDishCart.Width = 80;
            // 
            // columnSum
            // 
            columnSum.Text = "Сумма";
            columnSum.Width = 100;
            // 
            // textBoxClientSearch
            // 
            textBoxClientSearch.Font = new Font("Segoe UI", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 204);
            textBoxClientSearch.Location = new Point(6, 6);
            textBoxClientSearch.Name = "textBoxClientSearch";
            textBoxClientSearch.Size = new Size(924, 30);
            textBoxClientSearch.TabIndex = 1;
            textBoxClientSearch.Text = "Поиск по названию...";
            // 
            // listViewClientMenu
            // 
            listViewClientMenu.BackColor = Color.FromArgb(234, 215, 209);
            listViewClientMenu.Columns.AddRange(new ColumnHeader[] { columnNameDishMenu, columnPriceDish, columnPictureDish });
            listViewGroup11.Header = "GroupSnacks";
            listViewGroup11.Name = "Закуски";
            listViewGroup12.Header = "GroupSoups";
            listViewGroup12.Name = "Супы";
            listViewGroup13.Header = "GroupSecondCourses";
            listViewGroup13.Name = "Вторые блюда";
            listViewGroup14.Header = "GroupDesserts";
            listViewGroup14.Name = "Десерты";
            listViewGroup15.Header = "GroupDrinks";
            listViewGroup15.Name = "Напитки";
            listViewClientMenu.Groups.AddRange(new ListViewGroup[] { listViewGroup11, listViewGroup12, listViewGroup13, listViewGroup14, listViewGroup15 });
            listViewItem5.Group = listViewGroup11;
            listViewItem6.Group = listViewGroup12;
            listViewClientMenu.Items.AddRange(new ListViewItem[] { listViewItem5, listViewItem6 });
            listViewClientMenu.Location = new Point(3, 42);
            listViewClientMenu.Name = "listViewClientMenu";
            listViewClientMenu.Size = new Size(506, 622);
            listViewClientMenu.TabIndex = 0;
            listViewClientMenu.UseCompatibleStateImageBehavior = false;
            listViewClientMenu.View = View.Details;
            // 
            // columnNameDishMenu
            // 
            columnNameDishMenu.Text = "Название";
            columnNameDishMenu.Width = 200;
            // 
            // columnPriceDish
            // 
            columnPriceDish.Text = "Цена";
            columnPriceDish.Width = 100;
            // 
            // columnPictureDish
            // 
            columnPictureDish.Text = "Изображение";
            columnPictureDish.Width = 200;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(pictureBoxIcon);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(150, 703);
            panel1.TabIndex = 2;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(99, 58, 52);
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(3, 618);
            button1.Name = "button1";
            button1.Size = new Size(141, 75);
            button1.TabIndex = 5;
            button1.Text = "Профиль";
            button1.UseVisualStyleBackColor = false;
            // 
            // pictureBoxIcon
            // 
            pictureBoxIcon.Dock = DockStyle.Top;
            pictureBoxIcon.Image = Properties.Resources.menu_restaurant_coffee_icon_210208;
            pictureBoxIcon.Location = new Point(0, 0);
            pictureBoxIcon.Name = "pictureBoxIcon";
            pictureBoxIcon.Size = new Size(150, 150);
            pictureBoxIcon.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxIcon.TabIndex = 0;
            pictureBoxIcon.TabStop = false;
            // 
            // tabPageClientCurrentOrder
            // 
            tabPageClientCurrentOrder.BackColor = Color.FromArgb(99, 58, 52);
            tabPageClientCurrentOrder.Controls.Add(listViewClientCurrentOrder);
            tabPageClientCurrentOrder.Cursor = Cursors.Hand;
            tabPageClientCurrentOrder.Location = new Point(4, 29);
            tabPageClientCurrentOrder.Name = "tabPageClientCurrentOrder";
            tabPageClientCurrentOrder.Padding = new Padding(3);
            tabPageClientCurrentOrder.Size = new Size(936, 667);
            tabPageClientCurrentOrder.TabIndex = 2;
            tabPageClientCurrentOrder.Text = "Текущий заказ";
            // 
            // listViewClientCurrentOrder
            // 
            listViewClientCurrentOrder.BackColor = Color.FromArgb(234, 215, 209);
            listViewClientCurrentOrder.Columns.AddRange(new ColumnHeader[] { columnNameDishCurrentOrder, columnStatus });
            listViewClientCurrentOrder.ForeColor = SystemColors.ControlLightLight;
            listViewClientCurrentOrder.Location = new Point(6, 6);
            listViewClientCurrentOrder.Name = "listViewClientCurrentOrder";
            listViewClientCurrentOrder.Size = new Size(924, 655);
            listViewClientCurrentOrder.TabIndex = 0;
            listViewClientCurrentOrder.UseCompatibleStateImageBehavior = false;
            listViewClientCurrentOrder.View = View.Details;
            // 
            // columnNameDishCurrentOrder
            // 
            columnNameDishCurrentOrder.Text = "Назвние блюда";
            columnNameDishCurrentOrder.Width = 500;
            // 
            // columnStatus
            // 
            columnStatus.Text = "Статус готовности";
            columnStatus.Width = 400;
            // 
            // ClientControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.White;
            Controls.Add(tabControlClient);
            Controls.Add(panel1);
            Name = "ClientControl";
            Size = new Size(1100, 703);
            tabControlClient.ResumeLayout(false);
            tabPageClientMenu.ResumeLayout(false);
            tabPageClientMenu.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxIcon).EndInit();
            tabPageClientCurrentOrder.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private TabControl tabControlClient;
        private TabPage tabPageClientMenu;
        private TextBox textBoxClientSearch;
        private ListView listViewClientMenu;
        private ColumnHeader columnNameDishMenu;
        private ColumnHeader columnPriceDish;
        private ColumnHeader columnPictureDish;
        private Panel panel1;
        private PictureBox pictureBoxIcon;
        private ListView listViewClientCart;
        private ColumnHeader columnNameDish;
        private ColumnHeader columnCountDishCart;
        private ColumnHeader columnSum;
        private Label labelClientTotalPrice;
        private Button buttonFormClientOrder;
        private Button button1;
        private TabPage tabPageClientCurrentOrder;
        private ListView listViewClientCurrentOrder;
        private ColumnHeader columnNameDishCurrentOrder;
        private ColumnHeader columnStatus;
    }
}
