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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            panel1 = new Panel();
            buttonChefLogout = new Button();
            buttonChefProfile = new Button();
            pictureBoxIcon = new PictureBox();
            textBoxChefOrders = new TextBox();
            textBoxChefNotReady = new TextBox();
            textBoxChefReady = new TextBox();
            button = new Button();
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
            panel1.Controls.Add(buttonChefLogout);
            panel1.Controls.Add(buttonChefProfile);
            panel1.Controls.Add(pictureBoxIcon);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(150, 705);
            panel1.TabIndex = 0;
            // 
            // buttonChefLogout
            // 
            buttonChefLogout.BackColor = Color.FromArgb(99, 58, 52);
            buttonChefLogout.Cursor = Cursors.Hand;
            buttonChefLogout.Dock = DockStyle.Bottom;
            buttonChefLogout.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonChefLogout.ForeColor = SystemColors.ControlLightLight;
            buttonChefLogout.Location = new Point(0, 636);
            buttonChefLogout.Name = "buttonChefLogout";
            buttonChefLogout.Size = new Size(150, 69);
            buttonChefLogout.TabIndex = 18;
            buttonChefLogout.Text = "Выход";
            buttonChefLogout.UseVisualStyleBackColor = false;
            buttonChefLogout.Click += buttonChefLogout_Click;
            // 
            // buttonChefProfile
            // 
            buttonChefProfile.BackColor = Color.FromArgb(99, 58, 52);
            buttonChefProfile.Cursor = Cursors.Hand;
            buttonChefProfile.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonChefProfile.ForeColor = SystemColors.ControlLightLight;
            buttonChefProfile.Location = new Point(0, 156);
            buttonChefProfile.Name = "buttonChefProfile";
            buttonChefProfile.Size = new Size(150, 75);
            buttonChefProfile.TabIndex = 9;
            buttonChefProfile.Text = "Профиль";
            buttonChefProfile.UseVisualStyleBackColor = false;
            buttonChefProfile.Click += buttonChefProfile_Click;
            // 
            // pictureBoxIcon
            // 
            pictureBoxIcon.Dock = DockStyle.Top;
            pictureBoxIcon.Image = Properties.Resources.menu_restaurant_coffee_icon_210208;
            pictureBoxIcon.Location = new Point(0, 0);
            pictureBoxIcon.Name = "pictureBoxIcon";
            pictureBoxIcon.Size = new Size(150, 149);
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
            textBoxChefOrders.Location = new Point(162, 13);
            textBoxChefOrders.Name = "textBoxChefOrders";
            textBoxChefOrders.Size = new Size(223, 20);
            textBoxChefOrders.TabIndex = 2;
            textBoxChefOrders.Text = "Список активных заказов (ID)";
            // 
            // textBoxChefNotReady
            // 
            textBoxChefNotReady.BackColor = Color.FromArgb(99, 58, 52);
            textBoxChefNotReady.BorderStyle = BorderStyle.None;
            textBoxChefNotReady.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            textBoxChefNotReady.ForeColor = SystemColors.ControlLightLight;
            textBoxChefNotReady.Location = new Point(391, 13);
            textBoxChefNotReady.Name = "textBoxChefNotReady";
            textBoxChefNotReady.Size = new Size(250, 20);
            textBoxChefNotReady.TabIndex = 5;
            textBoxChefNotReady.Text = "Список не готовых блюд";
            // 
            // textBoxChefReady
            // 
            textBoxChefReady.BackColor = Color.FromArgb(99, 58, 52);
            textBoxChefReady.BorderStyle = BorderStyle.None;
            textBoxChefReady.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            textBoxChefReady.ForeColor = SystemColors.ControlLightLight;
            textBoxChefReady.Location = new Point(798, 13);
            textBoxChefReady.Name = "textBoxChefReady";
            textBoxChefReady.Size = new Size(250, 20);
            textBoxChefReady.TabIndex = 6;
            textBoxChefReady.Text = "Список готовых блюд";
            // 
            // button
            // 
            button.BackColor = Color.FromArgb(99, 58, 52);
            button.Cursor = Cursors.Hand;
            button.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button.ForeColor = SystemColors.ControlLightLight;
            button.Location = new Point(597, 301);
            button.Name = "button";
            button.Size = new Size(199, 75);
            button.TabIndex = 10;
            button.Text = "Готово ⇒";
            button.UseVisualStyleBackColor = false;
            button.Click += button_Click;
            // 
            // IDGrid
            // 
            dataGridViewCellStyle1.ForeColor = Color.Black;
            IDGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            IDGrid.BackgroundColor = Color.FromArgb(234, 215, 209);
            IDGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            IDGrid.Columns.AddRange(new DataGridViewColumn[] { ID });
            IDGrid.Location = new Point(162, 40);
            IDGrid.Margin = new Padding(3, 4, 3, 4);
            IDGrid.Name = "IDGrid";
            IDGrid.RowHeadersWidth = 51;
            IDGrid.Size = new Size(206, 652);
            IDGrid.TabIndex = 11;
            IDGrid.CellClick += IDGrid_CellClick;
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
            NotGrid.BackgroundColor = Color.FromArgb(234, 215, 209);
            NotGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            NotGrid.Columns.AddRange(new DataGridViewColumn[] { NCooked });
            NotGrid.Location = new Point(385, 40);
            NotGrid.Margin = new Padding(3, 4, 3, 4);
            NotGrid.Name = "NotGrid";
            NotGrid.RowHeadersWidth = 51;
            NotGrid.Size = new Size(206, 652);
            NotGrid.TabIndex = 12;
            NotGrid.CellClick += NotGrid_CellClick;
            // 
            // NCooked
            // 
            NCooked.HeaderText = "Не готовы";
            NCooked.MinimumWidth = 6;
            NCooked.Name = "NCooked";
            NCooked.Width = 150;
            // 
            // YeGrid
            // 
            YeGrid.BackgroundColor = Color.FromArgb(234, 215, 209);
            YeGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            YeGrid.Columns.AddRange(new DataGridViewColumn[] { Cooked });
            YeGrid.Location = new Point(802, 40);
            YeGrid.Margin = new Padding(3, 4, 3, 4);
            YeGrid.Name = "YeGrid";
            YeGrid.RowHeadersWidth = 51;
            YeGrid.Size = new Size(219, 652);
            YeGrid.TabIndex = 13;
            // 
            // Cooked
            // 
            Cooked.HeaderText = "Готовы";
            Cooked.MinimumWidth = 6;
            Cooked.Name = "Cooked";
            Cooked.Width = 150;
            // 
            // ChefControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.FromArgb(99, 58, 52);
            Controls.Add(YeGrid);
            Controls.Add(NotGrid);
            Controls.Add(IDGrid);
            Controls.Add(button);
            Controls.Add(textBoxChefReady);
            Controls.Add(textBoxChefNotReady);
            Controls.Add(textBoxChefOrders);
            Controls.Add(panel1);
            Name = "ChefControl";
            Size = new Size(1051, 705);
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
        private Button button;
        private Button buttonChefProfile;
        private Button buttonChefLogout;
        private DataGridView IDGrid;
        private DataGridViewTextBoxColumn ID;
        private DataGridView NotGrid;
        private DataGridViewTextBoxColumn NCooked;
        private DataGridView YeGrid;
        private DataGridViewTextBoxColumn Cooked;
    }
}
