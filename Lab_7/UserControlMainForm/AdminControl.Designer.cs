namespace Lab_7
{
    partial class AdminControl
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
            comboBoxAdminEmployeeType = new ComboBox();
            panel1 = new Panel();
            buttonAdminLogout = new Button();
            buttonAdminRegisterEmployee = new Button();
            buttonStatsAdmin = new Button();
            buttonWaiterProfile = new Button();
            pictureBoxIcon = new PictureBox();
            listViewAdminEmployees = new ListView();
            columnEmployeeID = new ColumnHeader();
            columnNameEmployee = new ColumnHeader();
            columnTypeEmployee = new ColumnHeader();
            columnPhoneEmployee = new ColumnHeader();
            columnLogin = new ColumnHeader();
            columnEffectiveness = new ColumnHeader();
            textBoxAdminEmployeeType = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxIcon).BeginInit();
            SuspendLayout();
            // 
            // comboBoxAdminEmployeeType
            // 
            comboBoxAdminEmployeeType.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxAdminEmployeeType.Font = new Font("Segoe UI", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 204);
            comboBoxAdminEmployeeType.FormattingEnabled = true;
            comboBoxAdminEmployeeType.Items.AddRange(new object[] { "Все", "Официант", "Повар", "Курьер", "Администратор" });
            comboBoxAdminEmployeeType.Location = new Point(408, 7);
            comboBoxAdminEmployeeType.Name = "comboBoxAdminEmployeeType";
            comboBoxAdminEmployeeType.Size = new Size(678, 31);
            comboBoxAdminEmployeeType.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(buttonAdminLogout);
            panel1.Controls.Add(buttonAdminRegisterEmployee);
            panel1.Controls.Add(buttonStatsAdmin);
            panel1.Controls.Add(buttonWaiterProfile);
            panel1.Controls.Add(pictureBoxIcon);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(150, 703);
            panel1.TabIndex = 1;
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
            buttonAdminLogout.TabIndex = 17;
            buttonAdminLogout.Text = "Выход";
            buttonAdminLogout.UseVisualStyleBackColor = false;
            buttonAdminLogout.Click += buttonAdminLogout_Click;
            // 
            // buttonAdminRegisterEmployee
            // 
            buttonAdminRegisterEmployee.BackColor = Color.FromArgb(99, 58, 52);
            buttonAdminRegisterEmployee.Cursor = Cursors.Hand;
            buttonAdminRegisterEmployee.Enabled = false;
            buttonAdminRegisterEmployee.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonAdminRegisterEmployee.ForeColor = SystemColors.ControlLightLight;
            buttonAdminRegisterEmployee.Location = new Point(0, 366);
            buttonAdminRegisterEmployee.Name = "buttonAdminRegisterEmployee";
            buttonAdminRegisterEmployee.Size = new Size(150, 98);
            buttonAdminRegisterEmployee.TabIndex = 16;
            buttonAdminRegisterEmployee.Text = "Регистрация нового сотрудника";
            buttonAdminRegisterEmployee.UseVisualStyleBackColor = false;
            // 
            // buttonStatsAdmin
            // 
            buttonStatsAdmin.BackColor = Color.FromArgb(99, 58, 52);
            buttonStatsAdmin.Cursor = Cursors.Hand;
            buttonStatsAdmin.Enabled = false;
            buttonStatsAdmin.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonStatsAdmin.ForeColor = SystemColors.ControlLightLight;
            buttonStatsAdmin.Location = new Point(0, 261);
            buttonStatsAdmin.Name = "buttonStatsAdmin";
            buttonStatsAdmin.Size = new Size(150, 99);
            buttonStatsAdmin.TabIndex = 16;
            buttonStatsAdmin.Text = "Общая статистика клиентов";
            buttonStatsAdmin.UseVisualStyleBackColor = false;
            // 
            // buttonWaiterProfile
            // 
            buttonWaiterProfile.BackColor = Color.FromArgb(99, 58, 52);
            buttonWaiterProfile.Cursor = Cursors.Hand;
            buttonWaiterProfile.Enabled = false;
            buttonWaiterProfile.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonWaiterProfile.ForeColor = SystemColors.ControlLightLight;
            buttonWaiterProfile.Location = new Point(0, 156);
            buttonWaiterProfile.Name = "buttonWaiterProfile";
            buttonWaiterProfile.Size = new Size(150, 75);
            buttonWaiterProfile.TabIndex = 15;
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
            pictureBoxIcon.TabIndex = 14;
            pictureBoxIcon.TabStop = false;
            // 
            // listViewAdminEmployees
            // 
            listViewAdminEmployees.BackColor = Color.FromArgb(234, 215, 209);
            listViewAdminEmployees.Columns.AddRange(new ColumnHeader[] { columnEmployeeID, columnNameEmployee, columnTypeEmployee, columnPhoneEmployee, columnLogin, columnEffectiveness });
            listViewAdminEmployees.Location = new Point(156, 44);
            listViewAdminEmployees.Name = "listViewAdminEmployees";
            listViewAdminEmployees.Size = new Size(930, 656);
            listViewAdminEmployees.TabIndex = 2;
            listViewAdminEmployees.UseCompatibleStateImageBehavior = false;
            listViewAdminEmployees.View = View.Details;
            // 
            // columnEmployeeID
            // 
            columnEmployeeID.Text = "ID сотрудника";
            columnEmployeeID.Width = 120;
            // 
            // columnNameEmployee
            // 
            columnNameEmployee.Text = "Имя сотрудника";
            columnNameEmployee.Width = 200;
            // 
            // columnTypeEmployee
            // 
            columnTypeEmployee.Text = "Тип работника";
            columnTypeEmployee.Width = 150;
            // 
            // columnPhoneEmployee
            // 
            columnPhoneEmployee.Text = "Телефон";
            columnPhoneEmployee.Width = 130;
            // 
            // columnLogin
            // 
            columnLogin.Text = "Login";
            columnLogin.Width = 170;
            // 
            // columnEffectiveness
            // 
            columnEffectiveness.Text = "Эффективность";
            columnEffectiveness.Width = 150;
            // 
            // textBoxAdminEmployeeType
            // 
            textBoxAdminEmployeeType.BackColor = Color.FromArgb(99, 58, 52);
            textBoxAdminEmployeeType.BorderStyle = BorderStyle.None;
            textBoxAdminEmployeeType.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            textBoxAdminEmployeeType.ForeColor = SystemColors.ControlLightLight;
            textBoxAdminEmployeeType.Location = new Point(156, 8);
            textBoxAdminEmployeeType.Name = "textBoxAdminEmployeeType";
            textBoxAdminEmployeeType.Size = new Size(234, 24);
            textBoxAdminEmployeeType.TabIndex = 3;
            textBoxAdminEmployeeType.Text = "Выбор типа сотрудника:";
            // 
            // AdminControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.FromArgb(99, 58, 52);
            Controls.Add(textBoxAdminEmployeeType);
            Controls.Add(listViewAdminEmployees);
            Controls.Add(panel1);
            Controls.Add(comboBoxAdminEmployeeType);
            Name = "AdminControl";
            Size = new Size(1092, 703);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxIcon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxAdminEmployeeType;
        private Panel panel1;
        private Button buttonStatsAdmin;
        private Button buttonWaiterProfile;
        private PictureBox pictureBoxIcon;
        private ListView listViewAdminEmployees;
        private TextBox textBoxAdminEmployeeType;
        private ColumnHeader columnEmployeeID;
        private ColumnHeader columnNameEmployee;
        private ColumnHeader columnTypeEmployee;
        private ColumnHeader columnPhoneEmployee;
        private ColumnHeader columnLogin;
        private ColumnHeader columnEffectiveness;
        private Button buttonAdminRegisterEmployee;
        private Button buttonAdminLogout;
    }
}
