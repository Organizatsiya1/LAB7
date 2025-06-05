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
            textBoxClientCart = new TextBox();
            labelClientPriceTotal = new Label();
            listViewClientCart = new ListView();
            columnNameDish = new ColumnHeader();
            columnCountDishCart = new ColumnHeader();
            columnSum = new ColumnHeader();
            buttonFormClientOrder = new Button();
            labelClientTotalPrice = new Label();
            textBoxClientSearch = new TextBox();
            listViewClientMenu = new ListView();
            columnNameDishMenu = new ColumnHeader();
            columnPriceDish = new ColumnHeader();
            columnPictureDish = new ColumnHeader();
            tabPageClientCurrentOrder = new TabPage();
            textBoxWaiterOrderItems = new TextBox();
            listViewClientCurrentOrder = new ListView();
            columnNameDishCurrentOrder = new ColumnHeader();
            columnStatus = new ColumnHeader();
            panel1 = new Panel();
            buttonClientProfile = new Button();
            pictureBoxIcon = new PictureBox();
            tabControlClient.SuspendLayout();
            tabPageClientMenu.SuspendLayout();
            tabPageClientCurrentOrder.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxIcon).BeginInit();
            SuspendLayout();
            // 
            // tabControlClient
            // 
            tabControlClient.Controls.Add(tabPageClientMenu);
            tabControlClient.Controls.Add(tabPageClientCurrentOrder);
            tabControlClient.Location = new Point(150, 3);
            tabControlClient.Name = "tabControlClient";
            tabControlClient.SelectedIndex = 0;
            tabControlClient.Size = new Size(944, 697);
            tabControlClient.TabIndex = 1;
            // 
            // tabPageClientMenu
            // 
            tabPageClientMenu.BackColor = Color.FromArgb(99, 58, 52);
            tabPageClientMenu.Controls.Add(textBoxClientCart);
            tabPageClientMenu.Controls.Add(labelClientPriceTotal);
            tabPageClientMenu.Controls.Add(listViewClientCart);
            tabPageClientMenu.Controls.Add(buttonFormClientOrder);
            tabPageClientMenu.Controls.Add(labelClientTotalPrice);
            tabPageClientMenu.Controls.Add(textBoxClientSearch);
            tabPageClientMenu.Controls.Add(listViewClientMenu);
            tabPageClientMenu.Cursor = Cursors.Hand;
            tabPageClientMenu.Location = new Point(4, 29);
            tabPageClientMenu.Name = "tabPageClientMenu";
            tabPageClientMenu.Padding = new Padding(3);
            tabPageClientMenu.Size = new Size(936, 664);
            tabPageClientMenu.TabIndex = 0;
            tabPageClientMenu.Text = "Меню";
            // 
            // textBoxClientCart
            // 
            textBoxClientCart.BackColor = Color.FromArgb(99, 58, 52);
            textBoxClientCart.BorderStyle = BorderStyle.None;
            textBoxClientCart.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            textBoxClientCart.ForeColor = SystemColors.ControlLightLight;
            textBoxClientCart.Location = new Point(518, 42);
            textBoxClientCart.Name = "textBoxClientCart";
            textBoxClientCart.Size = new Size(415, 23);
            textBoxClientCart.TabIndex = 13;
            textBoxClientCart.Text = "Корзина - список выбранных блюд";
            // 
            // labelClientPriceTotal
            // 
            labelClientPriceTotal.AutoSize = true;
            labelClientPriceTotal.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelClientPriceTotal.ForeColor = SystemColors.ControlLightLight;
            labelClientPriceTotal.Location = new Point(515, 553);
            labelClientPriceTotal.Name = "labelClientPriceTotal";
            labelClientPriceTotal.Size = new Size(91, 31);
            labelClientPriceTotal.TabIndex = 12;
            labelClientPriceTotal.Text = "Итого: ";
            // 
            // listViewClientCart
            // 
            listViewClientCart.BackColor = Color.FromArgb(234, 215, 209);
            listViewClientCart.Columns.AddRange(new ColumnHeader[] { columnNameDish, columnCountDishCart, columnSum });
            listViewClientCart.Location = new Point(515, 71);
            listViewClientCart.Name = "listViewClientCart";
            listViewClientCart.Size = new Size(415, 470);
            listViewClientCart.TabIndex = 11;
            listViewClientCart.UseCompatibleStateImageBehavior = false;
            listViewClientCart.View = View.Details;
            listViewClientCart.ItemSelectionChanged += listViewClientCart_ItemSelectionChanged;
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
            buttonFormClientOrder.Click += buttonFormClientOrder_Click;
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
            // textBoxClientSearch
            // 
            textBoxClientSearch.Font = new Font("Segoe UI", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 204);
            textBoxClientSearch.Location = new Point(6, 6);
            textBoxClientSearch.Name = "textBoxClientSearch";
            textBoxClientSearch.Size = new Size(924, 30);
            textBoxClientSearch.TabIndex = 1;
            textBoxClientSearch.Text = "Поиск по названию...";
            textBoxClientSearch.TextChanged += textBoxClientSearch_TextChanged;
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
            listViewClientMenu.Location = new Point(6, 42);
            listViewClientMenu.Name = "listViewClientMenu";
            listViewClientMenu.Size = new Size(503, 619);
            listViewClientMenu.TabIndex = 0;
            listViewClientMenu.UseCompatibleStateImageBehavior = false;
            listViewClientMenu.View = View.Details;
            listViewClientMenu.ItemActivate += listViewClientMenu_ItemActivate;
            listViewClientMenu.DoubleClick += listViewClientMenu_DoubleClick;
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
            // tabPageClientCurrentOrder
            // 
            tabPageClientCurrentOrder.BackColor = Color.FromArgb(99, 58, 52);
            tabPageClientCurrentOrder.Controls.Add(textBoxWaiterOrderItems);
            tabPageClientCurrentOrder.Controls.Add(listViewClientCurrentOrder);
            tabPageClientCurrentOrder.Cursor = Cursors.Hand;
            tabPageClientCurrentOrder.Location = new Point(4, 29);
            tabPageClientCurrentOrder.Name = "tabPageClientCurrentOrder";
            tabPageClientCurrentOrder.Padding = new Padding(3);
            tabPageClientCurrentOrder.Size = new Size(936, 664);
            tabPageClientCurrentOrder.TabIndex = 2;
            tabPageClientCurrentOrder.Text = "Текущий заказ";
            // 
            // textBoxWaiterOrderItems
            // 
            textBoxWaiterOrderItems.BackColor = Color.FromArgb(99, 58, 52);
            textBoxWaiterOrderItems.BorderStyle = BorderStyle.None;
            textBoxWaiterOrderItems.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            textBoxWaiterOrderItems.ForeColor = SystemColors.ControlLightLight;
            textBoxWaiterOrderItems.Location = new Point(6, 6);
            textBoxWaiterOrderItems.Name = "textBoxWaiterOrderItems";
            textBoxWaiterOrderItems.Size = new Size(474, 23);
            textBoxWaiterOrderItems.TabIndex = 11;
            textBoxWaiterOrderItems.Text = "Список готовности блюд";
            // 
            // listViewClientCurrentOrder
            // 
            listViewClientCurrentOrder.BackColor = Color.FromArgb(234, 215, 209);
            listViewClientCurrentOrder.Columns.AddRange(new ColumnHeader[] { columnNameDishCurrentOrder, columnStatus });
            listViewClientCurrentOrder.ForeColor = SystemColors.ControlLightLight;
            listViewClientCurrentOrder.Location = new Point(6, 35);
            listViewClientCurrentOrder.Name = "listViewClientCurrentOrder";
            listViewClientCurrentOrder.Size = new Size(924, 626);
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
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(buttonClientProfile);
            panel1.Controls.Add(pictureBoxIcon);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(150, 703);
            panel1.TabIndex = 2;
            // 
            // buttonClientProfile
            // 
            buttonClientProfile.BackColor = Color.FromArgb(99, 58, 52);
            buttonClientProfile.Cursor = Cursors.Hand;
            buttonClientProfile.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonClientProfile.ForeColor = SystemColors.ControlLightLight;
            buttonClientProfile.Location = new Point(3, 618);
            buttonClientProfile.Name = "buttonClientProfile";
            buttonClientProfile.Size = new Size(141, 75);
            buttonClientProfile.TabIndex = 5;
            buttonClientProfile.Text = "Профиль";
            buttonClientProfile.UseVisualStyleBackColor = false;
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
            // ClientControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = SystemColors.Control;
            Controls.Add(tabControlClient);
            Controls.Add(panel1);
            Name = "ClientControl";
            Size = new Size(1100, 703);
            tabControlClient.ResumeLayout(false);
            tabPageClientMenu.ResumeLayout(false);
            tabPageClientMenu.PerformLayout();
            tabPageClientCurrentOrder.ResumeLayout(false);
            tabPageClientCurrentOrder.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxIcon).EndInit();
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
        private Label labelClientTotalPrice;
        private Button buttonFormClientOrder;
        private Button buttonClientProfile;
        private TabPage tabPageClientCurrentOrder;
        private ListView listViewClientCurrentOrder;
        private ColumnHeader columnNameDishCurrentOrder;
        private ColumnHeader columnStatus;
        private TextBox textBoxClientCart;
        private Label labelClientPriceTotal;
        private ListView listViewClientCart;
        private ColumnHeader columnNameDish;
        private ColumnHeader columnCountDishCart;
        private ColumnHeader columnSum;
        private TextBox textBoxWaiterOrderItems;
    }
}
