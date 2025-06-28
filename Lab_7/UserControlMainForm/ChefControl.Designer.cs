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
            listBoxChefOrders = new ListBox();
            textBoxChefOrders = new TextBox();
            listBox1 = new ListBox();
            listBoxChefReady = new ListBox();
            textBoxChefNotReady = new TextBox();
            textBoxChefReady = new TextBox();
            button1 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxIcon).BeginInit();
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
            panel1.Name = "panel1";
            panel1.Size = new Size(150, 703);
            panel1.TabIndex = 0;
            // 
            // buttonAdminLogout
            // 
            buttonAdminLogout.BackColor = Color.FromArgb(99, 58, 52);
            buttonAdminLogout.Cursor = Cursors.Hand;
            buttonAdminLogout.Dock = DockStyle.Bottom;
            buttonAdminLogout.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonAdminLogout.ForeColor = SystemColors.ControlLightLight;
            buttonAdminLogout.Location = new Point(0, 633);
            buttonAdminLogout.Name = "buttonAdminLogout";
            buttonAdminLogout.Size = new Size(150, 70);
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
            buttonWaiterProfile.Location = new Point(0, 156);
            buttonWaiterProfile.Name = "buttonWaiterProfile";
            buttonWaiterProfile.Size = new Size(150, 75);
            buttonWaiterProfile.TabIndex = 9;
            buttonWaiterProfile.Text = "Профиль";
            buttonWaiterProfile.UseVisualStyleBackColor = false;
            // 
            // pictureBoxIcon
            // 
            pictureBoxIcon.Dock = DockStyle.Top;
            pictureBoxIcon.Image = Properties.Resources.menu_restaurant_coffee_icon_210208;
            pictureBoxIcon.Location = new Point(0, 0);
            pictureBoxIcon.Name = "pictureBoxIcon";
            pictureBoxIcon.Size = new Size(150, 150);
            pictureBoxIcon.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxIcon.TabIndex = 8;
            pictureBoxIcon.TabStop = false;
            // 
            // listBoxChefOrders
            // 
            listBoxChefOrders.BackColor = Color.FromArgb(234, 215, 209);
            listBoxChefOrders.Location = new Point(156, 36);
            listBoxChefOrders.Name = "listBoxChefOrders";
            listBoxChefOrders.Size = new Size(223, 664);
            listBoxChefOrders.TabIndex = 1;
            // 
            // textBoxChefOrders
            // 
            textBoxChefOrders.BackColor = Color.FromArgb(99, 58, 52);
            textBoxChefOrders.BorderStyle = BorderStyle.None;
            textBoxChefOrders.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            textBoxChefOrders.ForeColor = SystemColors.ControlLightLight;
            textBoxChefOrders.Location = new Point(156, 3);
            textBoxChefOrders.Name = "textBoxChefOrders";
            textBoxChefOrders.Size = new Size(223, 20);
            textBoxChefOrders.TabIndex = 2;
            textBoxChefOrders.Text = "Список активных заказов (ID)";
            // 
            // listBox1
            // 
            listBox1.BackColor = Color.FromArgb(234, 215, 209);
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(385, 36);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(250, 664);
            listBox1.TabIndex = 3;
            // 
            // listBoxChefReady
            // 
            listBoxChefReady.BackColor = Color.FromArgb(234, 215, 209);
            listBoxChefReady.FormattingEnabled = true;
            listBoxChefReady.Location = new Point(846, 36);
            listBoxChefReady.Name = "listBoxChefReady";
            listBoxChefReady.Size = new Size(250, 664);
            listBoxChefReady.TabIndex = 4;
            // 
            // textBoxChefNotReady
            // 
            textBoxChefNotReady.BackColor = Color.FromArgb(99, 58, 52);
            textBoxChefNotReady.BorderStyle = BorderStyle.None;
            textBoxChefNotReady.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            textBoxChefNotReady.ForeColor = SystemColors.ControlLightLight;
            textBoxChefNotReady.Location = new Point(385, 3);
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
            textBoxChefReady.Location = new Point(846, 3);
            textBoxChefReady.Name = "textBoxChefReady";
            textBoxChefReady.Size = new Size(250, 20);
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
            button1.Location = new Point(641, 291);
            button1.Name = "button1";
            button1.Size = new Size(199, 75);
            button1.TabIndex = 10;
            button1.Text = "Готово ⇒";
            button1.UseVisualStyleBackColor = false;
            // 
            // ChefControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.FromArgb(99, 58, 52);
            Controls.Add(button1);
            Controls.Add(textBoxChefReady);
            Controls.Add(textBoxChefNotReady);
            Controls.Add(listBoxChefReady);
            Controls.Add(listBox1);
            Controls.Add(textBoxChefOrders);
            Controls.Add(listBoxChefOrders);
            Controls.Add(panel1);
            Name = "ChefControl";
            Size = new Size(1102, 703);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxIcon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBoxIcon;
        private ListBox listBoxChefOrders;
        private TextBox textBoxChefOrders;
        private ListBox listBox1;
        private ListBox listBoxChefReady;
        private TextBox textBoxChefNotReady;
        private TextBox textBoxChefReady;
        private Button button1;
        private Button buttonWaiterProfile;
        private Button buttonAdminLogout;
    }
}
