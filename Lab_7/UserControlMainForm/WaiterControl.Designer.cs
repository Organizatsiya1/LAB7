namespace Lab_7
{
    partial class WaiterControl
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
            components = new System.ComponentModel.Container();
            ListViewGroup listViewGroup7 = new ListViewGroup("Аперитив", HorizontalAlignment.Left);
            ListViewGroup listViewGroup8 = new ListViewGroup("Антре", HorizontalAlignment.Left);
            ListViewGroup listViewGroup9 = new ListViewGroup("Основное блюдо", HorizontalAlignment.Left);
            ListViewGroup listViewGroup10 = new ListViewGroup("Антреме", HorizontalAlignment.Left);
            ListViewGroup listViewGroup11 = new ListViewGroup("Десерт", HorizontalAlignment.Left);
            ListViewGroup listViewGroup12 = new ListViewGroup("Дижестив", HorizontalAlignment.Left);
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            panelWaiter = new Panel();
            buttonWaiterLogout = new Button();
            pictureBoxIcon = new PictureBox();
            tabControlWaiter = new TabControl();
            tabPageMenuWaiter = new TabPage();
            textBoxWaiterCart = new TextBox();
            buttonFormWaiterOrder = new Button();
            labelWaiterTotalPrice = new Label();
            listViewWaiterCart = new ListView();
            columnNameDish = new ColumnHeader();
            columnCountDishCart = new ColumnHeader();
            columnSum = new ColumnHeader();
            textBoxWaiterSearch = new TextBox();
            listViewWaiterMenu = new ListView();
            columnNameDishMenu = new ColumnHeader();
            columnPriceDish = new ColumnHeader();
            columnPictureDish = new ColumnHeader();
            imageListDishes = new ImageList(components);
            tabPageOrdersWaiter = new TabPage();
            textBoxWaiterOrderItems = new TextBox();
            textBoxWaiterOrders = new TextBox();
            buttonWaiterPayOrder = new Button();
            listViewWaiterOrderItems = new ListView();
            columnNameDishOrder = new ColumnHeader();
            columnOrderStatus = new ColumnHeader();
            listViewWaiterOrders = new ListView();
            columnOrderID = new ColumnHeader();
            columnStatus = new ColumnHeader();
            buttonWaiterProfile = new Button();
            tabControl1.SuspendLayout();
            panelWaiter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxIcon).BeginInit();
            tabControlWaiter.SuspendLayout();
            tabPageMenuWaiter.SuspendLayout();
            tabPageOrdersWaiter.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(156, 3);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(250, 125);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(242, 92);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(242, 92);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // panelWaiter
            // 
            panelWaiter.BackColor = SystemColors.Control;
            panelWaiter.Controls.Add(buttonWaiterLogout);
            panelWaiter.Controls.Add(buttonWaiterProfile);
            panelWaiter.Controls.Add(tabControl1);
            panelWaiter.Controls.Add(pictureBoxIcon);
            panelWaiter.Dock = DockStyle.Left;
            panelWaiter.Location = new Point(0, 0);
            panelWaiter.Name = "panelWaiter";
            panelWaiter.Size = new Size(150, 705);
            panelWaiter.TabIndex = 1;
            // 
            // buttonWaiterLogout
            // 
            buttonWaiterLogout.BackColor = Color.FromArgb(99, 58, 52);
            buttonWaiterLogout.Cursor = Cursors.Hand;
            buttonWaiterLogout.Dock = DockStyle.Bottom;
            buttonWaiterLogout.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonWaiterLogout.ForeColor = SystemColors.ControlLightLight;
            buttonWaiterLogout.Location = new Point(0, 635);
            buttonWaiterLogout.Name = "buttonWaiterLogout";
            buttonWaiterLogout.Size = new Size(150, 70);
            buttonWaiterLogout.TabIndex = 8;
            buttonWaiterLogout.Text = "Выход";
            buttonWaiterLogout.UseVisualStyleBackColor = false;
            buttonWaiterLogout.Click += buttonWaiterLogout_Click;
            // 
            // pictureBoxIcon
            // 
            pictureBoxIcon.Dock = DockStyle.Top;
            pictureBoxIcon.Image = Properties.Resources.menu_restaurant_coffee_icon_210208;
            pictureBoxIcon.Location = new Point(0, 0);
            pictureBoxIcon.Name = "pictureBoxIcon";
            pictureBoxIcon.Size = new Size(150, 150);
            pictureBoxIcon.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxIcon.TabIndex = 6;
            pictureBoxIcon.TabStop = false;
            // 
            // tabControlWaiter
            // 
            tabControlWaiter.Controls.Add(tabPageMenuWaiter);
            tabControlWaiter.Controls.Add(tabPageOrdersWaiter);
            tabControlWaiter.Location = new Point(150, 3);
            tabControlWaiter.Name = "tabControlWaiter";
            tabControlWaiter.SelectedIndex = 0;
            tabControlWaiter.Size = new Size(947, 699);
            tabControlWaiter.TabIndex = 2;
            // 
            // tabPageMenuWaiter
            // 
            tabPageMenuWaiter.BackColor = Color.FromArgb(99, 58, 52);
            tabPageMenuWaiter.Controls.Add(textBoxWaiterCart);
            tabPageMenuWaiter.Controls.Add(buttonFormWaiterOrder);
            tabPageMenuWaiter.Controls.Add(labelWaiterTotalPrice);
            tabPageMenuWaiter.Controls.Add(listViewWaiterCart);
            tabPageMenuWaiter.Controls.Add(textBoxWaiterSearch);
            tabPageMenuWaiter.Controls.Add(listViewWaiterMenu);
            tabPageMenuWaiter.Location = new Point(4, 29);
            tabPageMenuWaiter.Name = "tabPageMenuWaiter";
            tabPageMenuWaiter.Padding = new Padding(3);
            tabPageMenuWaiter.Size = new Size(939, 666);
            tabPageMenuWaiter.TabIndex = 0;
            tabPageMenuWaiter.Text = "Меню";
            // 
            // textBoxWaiterCart
            // 
            textBoxWaiterCart.BackColor = Color.FromArgb(99, 58, 52);
            textBoxWaiterCart.BorderStyle = BorderStyle.None;
            textBoxWaiterCart.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            textBoxWaiterCart.ForeColor = SystemColors.ControlLightLight;
            textBoxWaiterCart.Location = new Point(518, 42);
            textBoxWaiterCart.Name = "textBoxWaiterCart";
            textBoxWaiterCart.Size = new Size(415, 23);
            textBoxWaiterCart.TabIndex = 10;
            textBoxWaiterCart.Text = "Корзина - список выбранных блюд";
            // 
            // buttonFormWaiterOrder
            // 
            buttonFormWaiterOrder.Cursor = Cursors.Hand;
            buttonFormWaiterOrder.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonFormWaiterOrder.ForeColor = SystemColors.ControlLightLight;
            buttonFormWaiterOrder.Location = new Point(515, 599);
            buttonFormWaiterOrder.Name = "buttonFormWaiterOrder";
            buttonFormWaiterOrder.Size = new Size(415, 62);
            buttonFormWaiterOrder.TabIndex = 9;
            buttonFormWaiterOrder.Text = "Сделать заказ";
            buttonFormWaiterOrder.UseVisualStyleBackColor = false;
            buttonFormWaiterOrder.Click += buttonFormWaiterOrder_Click;
            // 
            // labelWaiterTotalPrice
            // 
            labelWaiterTotalPrice.AutoSize = true;
            labelWaiterTotalPrice.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelWaiterTotalPrice.ForeColor = SystemColors.ControlLightLight;
            labelWaiterTotalPrice.Location = new Point(515, 556);
            labelWaiterTotalPrice.Name = "labelWaiterTotalPrice";
            labelWaiterTotalPrice.Size = new Size(91, 31);
            labelWaiterTotalPrice.TabIndex = 8;
            labelWaiterTotalPrice.Text = "Итого: ";
            // 
            // listViewWaiterCart
            // 
            listViewWaiterCart.BackColor = Color.FromArgb(234, 215, 209);
            listViewWaiterCart.Columns.AddRange(new ColumnHeader[] { columnNameDish, columnCountDishCart, columnSum });
            listViewWaiterCart.Location = new Point(515, 71);
            listViewWaiterCart.Name = "listViewWaiterCart";
            listViewWaiterCart.Size = new Size(415, 473);
            listViewWaiterCart.TabIndex = 7;
            listViewWaiterCart.UseCompatibleStateImageBehavior = false;
            listViewWaiterCart.View = View.Details;
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
            // textBoxWaiterSearch
            // 
            textBoxWaiterSearch.Font = new Font("Segoe UI", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 204);
            textBoxWaiterSearch.Location = new Point(6, 6);
            textBoxWaiterSearch.Name = "textBoxWaiterSearch";
            textBoxWaiterSearch.Size = new Size(924, 30);
            textBoxWaiterSearch.TabIndex = 6;
            textBoxWaiterSearch.Text = "Поиск по названию...";
            textBoxWaiterSearch.TextChanged += textBoxWaiterSearch_TextChanged;
            // 
            // listViewWaiterMenu
            // 
            listViewWaiterMenu.BackColor = Color.FromArgb(234, 215, 209);
            listViewWaiterMenu.Columns.AddRange(new ColumnHeader[] { columnNameDishMenu, columnPriceDish, columnPictureDish });
            listViewGroup7.Header = "Аперитив";
            listViewGroup7.Name = "Аперитив";
            listViewGroup8.Header = "Антре";
            listViewGroup8.Name = "Антре";
            listViewGroup9.Header = "Основное блюдо";
            listViewGroup9.Name = "Основное блюдо";
            listViewGroup10.Header = "Антреме";
            listViewGroup10.Name = "Антреме";
            listViewGroup11.Header = "Десерт";
            listViewGroup11.Name = "Десерт";
            listViewGroup12.Header = "Дижестив";
            listViewGroup12.Name = "Дижестив";
            listViewWaiterMenu.Groups.AddRange(new ListViewGroup[] { listViewGroup7, listViewGroup8, listViewGroup9, listViewGroup10, listViewGroup11, listViewGroup12 });
            listViewWaiterMenu.LargeImageList = imageListDishes;
            listViewWaiterMenu.Location = new Point(6, 42);
            listViewWaiterMenu.Name = "listViewWaiterMenu";
            listViewWaiterMenu.Size = new Size(503, 619);
            listViewWaiterMenu.TabIndex = 5;
            listViewWaiterMenu.UseCompatibleStateImageBehavior = false;
            listViewWaiterMenu.View = View.Tile;
            listViewWaiterMenu.DoubleClick += listViewWaiterMenu_DoubleClick;
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
            // imageListDishes
            // 
            imageListDishes.ColorDepth = ColorDepth.Depth32Bit;
            imageListDishes.ImageSize = new Size(77, 77);
            imageListDishes.TransparentColor = Color.Transparent;
            // 
            // tabPageOrdersWaiter
            // 
            tabPageOrdersWaiter.BackColor = Color.FromArgb(99, 58, 52);
            tabPageOrdersWaiter.Controls.Add(textBoxWaiterOrderItems);
            tabPageOrdersWaiter.Controls.Add(textBoxWaiterOrders);
            tabPageOrdersWaiter.Controls.Add(buttonWaiterPayOrder);
            tabPageOrdersWaiter.Controls.Add(listViewWaiterOrderItems);
            tabPageOrdersWaiter.Controls.Add(listViewWaiterOrders);
            tabPageOrdersWaiter.Location = new Point(4, 29);
            tabPageOrdersWaiter.Name = "tabPageOrdersWaiter";
            tabPageOrdersWaiter.Padding = new Padding(3);
            tabPageOrdersWaiter.Size = new Size(939, 666);
            tabPageOrdersWaiter.TabIndex = 1;
            tabPageOrdersWaiter.Text = "Список текущих заказов";
            // 
            // textBoxWaiterOrderItems
            // 
            textBoxWaiterOrderItems.BackColor = Color.FromArgb(99, 58, 52);
            textBoxWaiterOrderItems.BorderStyle = BorderStyle.None;
            textBoxWaiterOrderItems.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            textBoxWaiterOrderItems.ForeColor = SystemColors.ControlLightLight;
            textBoxWaiterOrderItems.Location = new Point(459, 3);
            textBoxWaiterOrderItems.Name = "textBoxWaiterOrderItems";
            textBoxWaiterOrderItems.Size = new Size(474, 23);
            textBoxWaiterOrderItems.TabIndex = 10;
            textBoxWaiterOrderItems.Text = "Список готовности блюд";
            // 
            // textBoxWaiterOrders
            // 
            textBoxWaiterOrders.BackColor = Color.FromArgb(99, 58, 52);
            textBoxWaiterOrders.BorderStyle = BorderStyle.None;
            textBoxWaiterOrders.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            textBoxWaiterOrders.ForeColor = SystemColors.ControlLightLight;
            textBoxWaiterOrders.Location = new Point(6, 0);
            textBoxWaiterOrders.Name = "textBoxWaiterOrders";
            textBoxWaiterOrders.Size = new Size(444, 23);
            textBoxWaiterOrders.TabIndex = 9;
            textBoxWaiterOrders.Text = "Список из заказов, принятых официантом";
            // 
            // buttonWaiterPayOrder
            // 
            buttonWaiterPayOrder.BackColor = Color.FromArgb(99, 58, 52);
            buttonWaiterPayOrder.Cursor = Cursors.Hand;
            buttonWaiterPayOrder.Enabled = false;
            buttonWaiterPayOrder.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonWaiterPayOrder.ForeColor = SystemColors.ControlLightLight;
            buttonWaiterPayOrder.Location = new Point(6, 613);
            buttonWaiterPayOrder.Name = "buttonWaiterPayOrder";
            buttonWaiterPayOrder.Size = new Size(927, 48);
            buttonWaiterPayOrder.TabIndex = 8;
            buttonWaiterPayOrder.Text = "Оплатить заказ";
            buttonWaiterPayOrder.UseVisualStyleBackColor = false;
            buttonWaiterPayOrder.Click += buttonWaiterPayOrder_Click;
            // 
            // listViewWaiterOrderItems
            // 
            listViewWaiterOrderItems.BackColor = Color.FromArgb(234, 215, 209);
            listViewWaiterOrderItems.Columns.AddRange(new ColumnHeader[] { columnNameDishOrder, columnOrderStatus });
            listViewWaiterOrderItems.Location = new Point(459, 29);
            listViewWaiterOrderItems.Name = "listViewWaiterOrderItems";
            listViewWaiterOrderItems.Size = new Size(474, 575);
            listViewWaiterOrderItems.TabIndex = 1;
            listViewWaiterOrderItems.UseCompatibleStateImageBehavior = false;
            listViewWaiterOrderItems.View = View.Details;
            // 
            // columnNameDishOrder
            // 
            columnNameDishOrder.Text = "Название блюда";
            columnNameDishOrder.Width = 300;
            // 
            // columnOrderStatus
            // 
            columnOrderStatus.Text = "Состояние готовности";
            columnOrderStatus.Width = 200;
            // 
            // listViewWaiterOrders
            // 
            listViewWaiterOrders.BackColor = Color.FromArgb(234, 215, 209);
            listViewWaiterOrders.Columns.AddRange(new ColumnHeader[] { columnOrderID, columnStatus });
            listViewWaiterOrders.Location = new Point(6, 29);
            listViewWaiterOrders.Name = "listViewWaiterOrders";
            listViewWaiterOrders.Size = new Size(447, 575);
            listViewWaiterOrders.TabIndex = 0;
            listViewWaiterOrders.UseCompatibleStateImageBehavior = false;
            listViewWaiterOrders.View = View.Details;
            listViewWaiterOrders.SelectedIndexChanged += listViewWaiterOrders_SelectedIndexChanged;
            // 
            // columnOrderID
            // 
            columnOrderID.Text = "ID заказа";
            columnOrderID.Width = 200;
            // 
            // columnStatus
            // 
            columnStatus.Text = "Состояние заказа";
            columnStatus.Width = 225;
            // 
            // buttonWaiterProfile
            // 
            buttonWaiterProfile.BackColor = Color.FromArgb(99, 58, 52);
            buttonWaiterProfile.Cursor = Cursors.Hand;
            buttonWaiterProfile.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonWaiterProfile.ForeColor = SystemColors.ControlLightLight;
            buttonWaiterProfile.Location = new Point(0, 156);
            buttonWaiterProfile.Name = "buttonWaiterProfile";
            buttonWaiterProfile.Size = new Size(150, 75);
            buttonWaiterProfile.TabIndex = 7;
            buttonWaiterProfile.Text = "Профиль";
            buttonWaiterProfile.UseVisualStyleBackColor = false;
            buttonWaiterProfile.Click += buttonWaiterProfile_Click;
            // 
            // WaiterControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = SystemColors.Control;
            Controls.Add(tabControlWaiter);
            Controls.Add(panelWaiter);
            Name = "WaiterControl";
            Size = new Size(1100, 705);
            tabControl1.ResumeLayout(false);
            panelWaiter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxIcon).EndInit();
            tabControlWaiter.ResumeLayout(false);
            tabPageMenuWaiter.ResumeLayout(false);
            tabPageMenuWaiter.PerformLayout();
            tabPageOrdersWaiter.ResumeLayout(false);
            tabPageOrdersWaiter.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Panel panelWaiter;
        private PictureBox pictureBoxIcon;
        private TabControl tabControlWaiter;
        private TabPage tabPageMenuWaiter;
        private TabPage tabPageOrdersWaiter;
        private Button buttonFormWaiterOrder;
        private Label labelWaiterTotalPrice;
        private ListView listViewWaiterCart;
        private ColumnHeader columnNameDish;
        private ColumnHeader columnCountDishCart;
        private ColumnHeader columnSum;
        private TextBox textBoxWaiterSearch;
        private ListView listViewWaiterMenu;
        private ColumnHeader columnNameDishMenu;
        private ColumnHeader columnPriceDish;
        private ColumnHeader columnPictureDish;
        private ListView listViewWaiterOrderItems;
        private ListView listViewWaiterOrders;
        private ColumnHeader columnOrderID;
        private ColumnHeader columnStatus;
        private ColumnHeader columnNameDishOrder;
        private ColumnHeader columnOrderStatus;
        private Button buttonWaiterPayOrder;
        private TextBox textBoxWaiterCart;
        private TextBox textBoxWaiterOrderItems;
        private TextBox textBoxWaiterOrders;
        private Button buttonWaiterLogout;
        private ImageList imageListDishes;
        private Button buttonWaiterProfile;
    }
}
