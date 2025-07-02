namespace Lab_7
{
    partial class ChefControl
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
            panel1 = new Panel();
            buttonAdminLogout = new Button();
            buttonWaiterProfile = new Button();
            pictureBoxIcon = new PictureBox();
            textBoxChefOrders = new TextBox();
            textBoxChefNotReady = new TextBox();
            textBoxChefReady = new TextBox();
            button1 = new Button();
            IDGrid = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            NotGrid = new DataGridView();
            NCooked = new DataGridViewTextBoxColumn();
            YeGrid = new DataGridView();
            Cooked = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)IDGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NotGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)YeGrid).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(buttonAdminLogout);
            panel1.Controls.Add(buttonWaiterProfile);
            panel1.Controls.Add(pictureBoxIcon);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(131, 529);
            panel1.TabIndex = 0;
            // 
            // buttonAdminLogout
            // 
            buttonAdminLogout.BackColor = Color.FromArgb(99, 58, 52);
            buttonAdminLogout.Cursor = Cursors.Hand;
            buttonAdminLogout.Dock = DockStyle.Bottom;
            buttonAdminLogout.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonAdminLogout.ForeColor = SystemColors.ControlLightLight;
            buttonAdminLogout.Location = new Point(0, 477);
            buttonAdminLogout.Margin = new Padding(3, 2, 3, 2);
            buttonAdminLogout.Name = "buttonAdminLogout";
            buttonAdminLogout.Size = new Size(131, 52);
            buttonAdminLogout.TabIndex = 18;
            buttonAdminLogout.Text = "Выход";
            buttonAdminLogout.UseVisualStyleBackColor = false;
            buttonAdminLogout.Click += buttonAdminLogout_Click;
            // 
            // buttonWaiterProfile
            // 
            buttonWaiterProfile.BackColor = Color.FromArgb(99, 58, 52);
            buttonWaiterProfile.Cursor = Cursors.Hand;
            buttonWaiterProfile.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonWaiterProfile.ForeColor = SystemColors.ControlLightLight;
            buttonWaiterProfile.Location = new Point(0, 117);
            buttonWaiterProfile.Margin = new Padding(3, 2, 3, 2);
            buttonWaiterProfile.Name = "buttonWaiterProfile";
            buttonWaiterProfile.Size = new Size(131, 56);
            buttonWaiterProfile.TabIndex = 9;
            buttonWaiterProfile.Text = "Профиль";
            buttonWaiterProfile.UseVisualStyleBackColor = false;
            // 
            // pictureBoxIcon
            // 
            pictureBoxIcon.Dock = DockStyle.Top;
            pictureBoxIcon.Image = Properties.Resources.menu_restaurant_coffee_icon_210208;
            pictureBoxIcon.Location = new Point(0, 0);
            pictureBoxIcon.Margin = new Padding(3, 2, 3, 2);
            pictureBoxIcon.Name = "pictureBoxIcon";
            pictureBoxIcon.Size = new Size(131, 112);
            pictureBoxIcon.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxIcon.TabIndex = 8;
            pictureBoxIcon.TabStop = false;
            // 
            // textBoxChefOrders
            // 
            textBoxChefOrders.BackColor = Color.FromArgb(99, 58, 52);
            textBoxChefOrders.BorderStyle = BorderStyle.None;
            textBoxChefOrders.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            textBoxChefOrders.ForeColor = SystemColors.ControlLightLight;
            textBoxChefOrders.Location = new Point(136, 2);
            textBoxChefOrders.Margin = new Padding(3, 2, 3, 2);
            textBoxChefOrders.Name = "textBoxChefOrders";
            textBoxChefOrders.Size = new Size(195, 16);
            textBoxChefOrders.TabIndex = 2;
            textBoxChefOrders.Text = "Список активных заказов (ID)";
            // 
            // textBoxChefNotReady
            // 
            textBoxChefNotReady.BackColor = Color.FromArgb(99, 58, 52);
            textBoxChefNotReady.BorderStyle = BorderStyle.None;
            textBoxChefNotReady.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            textBoxChefNotReady.ForeColor = SystemColors.ControlLightLight;
            textBoxChefNotReady.Location = new Point(337, 2);
            textBoxChefNotReady.Margin = new Padding(3, 2, 3, 2);
            textBoxChefNotReady.Name = "textBoxChefNotReady";
            textBoxChefNotReady.Size = new Size(219, 16);
            textBoxChefNotReady.TabIndex = 5;
            textBoxChefNotReady.Text = "Список не готовых блюд";
            // 
            // textBoxChefReady
            // 
            textBoxChefReady.BackColor = Color.FromArgb(99, 58, 52);
            textBoxChefReady.BorderStyle = BorderStyle.None;
            textBoxChefReady.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            textBoxChefReady.ForeColor = SystemColors.ControlLightLight;
            textBoxChefReady.Location = new Point(740, 2);
            textBoxChefReady.Margin = new Padding(3, 2, 3, 2);
            textBoxChefReady.Name = "textBoxChefReady";
            textBoxChefReady.Size = new Size(219, 16);
            textBoxChefReady.TabIndex = 6;
            textBoxChefReady.Text = "Список готовых блюд";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(99, 58, 52);
            button1.Cursor = Cursors.Hand;
            button1.Enabled = false;
            button1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(561, 218);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(174, 56);
            button1.TabIndex = 10;
            button1.Text = "Готово ⇒";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // IDGrid
            // 
            IDGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            IDGrid.Columns.AddRange(new DataGridViewColumn[] { ID });
            IDGrid.Location = new Point(136, 30);
            IDGrid.Name = "IDGrid";
            IDGrid.Size = new Size(190, 496);
            IDGrid.TabIndex = 11;
            IDGrid.CellContentClick += IDGrid_CellContentClick;
            // 
            // ID
            // 
            ID.HeaderText = "ID Заказа";
            ID.MinimumWidth = 10;
            ID.Name = "ID";
            ID.Width = 150;
            // 
            // NotGrid
            // 
            NotGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            NotGrid.Columns.AddRange(new DataGridViewColumn[] { NCooked });
            NotGrid.Location = new Point(337, 30);
            NotGrid.Name = "NotGrid";
            NotGrid.Size = new Size(180, 495);
            NotGrid.TabIndex = 12;
            NotGrid.CellContentClick += NotGrid_CellContentClick;
            // 
            // NCooked
            // 
            NCooked.HeaderText = "Не готовы";
            NCooked.Name = "NCooked";
            NCooked.Width = 150;
            // 
            // YeGrid
            // 
            YeGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            YeGrid.Columns.AddRange(new DataGridViewColumn[] { Cooked });
            YeGrid.Location = new Point(742, 35);
            YeGrid.Name = "YeGrid";
            YeGrid.Size = new Size(192, 489);
            YeGrid.TabIndex = 13;
            // 
            // Cooked
            // 
            Cooked.HeaderText = "Готовы";
            Cooked.Name = "Cooked";
            Cooked.Width = 150;
            // 
            // ChefControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.FromArgb(99, 58, 52);
            Controls.Add(YeGrid);
            Controls.Add(NotGrid);
            Controls.Add(IDGrid);
            Controls.Add(button1);
            Controls.Add(textBoxChefReady);
            Controls.Add(textBoxChefNotReady);
            Controls.Add(textBoxChefOrders);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ChefControl";
            Size = new Size(964, 529);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)IDGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)NotGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)YeGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBoxIcon;
        private TextBox textBoxChefOrders;
        private TextBox textBoxChefNotReady;
        private TextBox textBoxChefReady;
        private Button button1;
        private Button buttonWaiterProfile;
        private Button buttonAdminLogout;
        private DataGridView IDGrid;
        private DataGridViewTextBoxColumn ID;
        private DataGridView NotGrid;
        private DataGridViewTextBoxColumn NCooked;
        private DataGridView YeGrid;
        private DataGridViewTextBoxColumn Cooked;
    }
}
