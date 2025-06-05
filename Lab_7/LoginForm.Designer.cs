namespace Lab_7
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            buttonCancel = new Button();
            buttonLogin = new Button();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            progressBar = new ProgressBar();
            radioEmployee = new RadioButton();
            radioClient = new RadioButton();
            groupBox1 = new GroupBox();
            buttonSendCode = new Button();
            maskedTextBoxCode = new MaskedTextBox();
            maskedTextBoxPhone = new MaskedTextBox();
            labelCode = new Label();
            labelPhone = new Label();
            labelLogin = new Label();
            labelPassword = new Label();
            textBoxLogin = new TextBox();
            textBoxPassword = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(buttonCancel);
            panel1.Controls.Add(buttonLogin);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(196, 207);
            panel1.TabIndex = 0;
            // 
            // buttonCancel
            // 
            buttonCancel.BackColor = Color.FromArgb(99, 58, 52);
            buttonCancel.Cursor = Cursors.Hand;
            buttonCancel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonCancel.ForeColor = SystemColors.ControlLightLight;
            buttonCancel.Location = new Point(10, 179);
            buttonCancel.Margin = new Padding(3, 2, 3, 2);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(178, 25);
            buttonCancel.TabIndex = 5;
            buttonCancel.Text = "Отмена";
            buttonCancel.UseVisualStyleBackColor = false;
            buttonCancel.Visible = false;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // buttonLogin
            // 
            buttonLogin.BackColor = Color.FromArgb(99, 58, 52);
            buttonLogin.Cursor = Cursors.Hand;
            buttonLogin.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonLogin.ForeColor = SystemColors.ControlLightLight;
            buttonLogin.Location = new Point(10, 151);
            buttonLogin.Margin = new Padding(3, 2, 3, 2);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(178, 25);
            buttonLogin.TabIndex = 4;
            buttonLogin.Text = "Вход";
            buttonLogin.UseVisualStyleBackColor = false;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.menu_restaurant_coffee_icon_210208;
            pictureBox1.Location = new Point(10, 9);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(178, 136);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(progressBar);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(196, 192);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(329, 15);
            panel2.TabIndex = 1;
            // 
            // progressBar
            // 
            progressBar.Location = new Point(0, 2);
            progressBar.Margin = new Padding(3, 2, 3, 2);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(326, 10);
            progressBar.TabIndex = 5;
            progressBar.Visible = false;
            // 
            // radioEmployee
            // 
            radioEmployee.AutoSize = true;
            radioEmployee.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            radioEmployee.ForeColor = SystemColors.ControlLightLight;
            radioEmployee.Location = new Point(222, 37);
            radioEmployee.Margin = new Padding(3, 2, 3, 2);
            radioEmployee.Name = "radioEmployee";
            radioEmployee.Size = new Size(103, 24);
            radioEmployee.TabIndex = 2;
            radioEmployee.TabStop = true;
            radioEmployee.Text = "Сотрудник";
            radioEmployee.UseVisualStyleBackColor = true;
            // 
            // radioClient
            // 
            radioClient.AutoSize = true;
            radioClient.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            radioClient.ForeColor = SystemColors.ControlLightLight;
            radioClient.Location = new Point(222, 63);
            radioClient.Margin = new Padding(3, 2, 3, 2);
            radioClient.Name = "radioClient";
            radioClient.Size = new Size(80, 24);
            radioClient.TabIndex = 3;
            radioClient.TabStop = true;
            radioClient.Text = "Клиент";
            radioClient.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(buttonSendCode);
            groupBox1.Controls.Add(maskedTextBoxCode);
            groupBox1.Controls.Add(maskedTextBoxPhone);
            groupBox1.Controls.Add(labelCode);
            groupBox1.Controls.Add(labelPhone);
            groupBox1.Controls.Add(labelLogin);
            groupBox1.Controls.Add(labelPassword);
            groupBox1.Controls.Add(textBoxLogin);
            groupBox1.Controls.Add(textBoxPassword);
            groupBox1.ForeColor = SystemColors.ControlLightLight;
            groupBox1.Location = new Point(201, 9);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(313, 181);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Добро пожаловать!";
            // 
            // buttonSendCode
            // 
            buttonSendCode.BackColor = Color.FromArgb(99, 58, 52);
            buttonSendCode.Cursor = Cursors.Hand;
            buttonSendCode.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonSendCode.ForeColor = SystemColors.ControlLightLight;
            buttonSendCode.Location = new Point(182, 112);
            buttonSendCode.Margin = new Padding(3, 2, 3, 2);
            buttonSendCode.Name = "buttonSendCode";
            buttonSendCode.Size = new Size(109, 25);
            buttonSendCode.TabIndex = 5;
            buttonSendCode.Text = "Отправить код";
            buttonSendCode.UseVisualStyleBackColor = false;
            buttonSendCode.Click += ButtonSendCode_Click;
            // 
            // maskedTextBoxCode
            // 
            maskedTextBoxCode.Location = new Point(199, 142);
            maskedTextBoxCode.Margin = new Padding(3, 2, 3, 2);
            maskedTextBoxCode.Mask = "0000";
            maskedTextBoxCode.Name = "maskedTextBoxCode";
            maskedTextBoxCode.Size = new Size(93, 23);
            maskedTextBoxCode.TabIndex = 8;
            maskedTextBoxCode.TextAlign = HorizontalAlignment.Center;
            maskedTextBoxCode.ValidatingType = typeof(int);
            // 
            // maskedTextBoxPhone
            // 
            maskedTextBoxPhone.Location = new Point(182, 88);
            maskedTextBoxPhone.Margin = new Padding(3, 2, 3, 2);
            maskedTextBoxPhone.Mask = "(999) 000-0000";
            maskedTextBoxPhone.Name = "maskedTextBoxPhone";
            maskedTextBoxPhone.Size = new Size(110, 23);
            maskedTextBoxPhone.TabIndex = 7;
            
            // 
            // labelCode
            // 
            labelCode.AutoSize = true;
            labelCode.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelCode.Location = new Point(18, 141);
            labelCode.Name = "labelCode";
            labelCode.Size = new Size(164, 20);
            labelCode.TabIndex = 5;
            labelCode.Text = "Код из уведомления:";
            // 
            // labelPhone
            // 
            labelPhone.AutoSize = true;
            labelPhone.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelPhone.Location = new Point(21, 88);
            labelPhone.Name = "labelPhone";
            labelPhone.Size = new Size(136, 20);
            labelPhone.TabIndex = 4;
            labelPhone.Text = "Номер телефона:";
            // 
            // labelLogin
            // 
            labelLogin.AutoSize = true;
            labelLogin.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelLogin.Location = new Point(45, 91);
            labelLogin.Name = "labelLogin";
            labelLogin.Size = new Size(57, 20);
            labelLogin.TabIndex = 1;
            labelLogin.Text = "Логин:";
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelPassword.Location = new Point(32, 121);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(67, 20);
            labelPassword.TabIndex = 0;
            labelPassword.Text = "Пароль:";
            // 
            // textBoxLogin
            // 
            textBoxLogin.Location = new Point(120, 94);
            textBoxLogin.Margin = new Padding(3, 2, 3, 2);
            textBoxLogin.Name = "textBoxLogin";
            textBoxLogin.Size = new Size(172, 23);
            textBoxLogin.TabIndex = 2;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(120, 122);
            textBoxPassword.Margin = new Padding(3, 2, 3, 2);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(172, 23);
            textBoxPassword.TabIndex = 3;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(99, 58, 52);
            ClientSize = new Size(525, 207);
            Controls.Add(radioClient);
            Controls.Add(radioEmployee);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 2, 3, 2);
            Name = "LoginForm";
            Text = "Restaurant Management System";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Panel panel2;
        private RadioButton radioEmployee;
        private Button buttonLogin;
        private RadioButton radioClient;
        private GroupBox groupBox1;
        private Label labelPhone;
        private Label labelLogin;
        private Label labelPassword;
        private TextBox textBoxLogin;
        private TextBox textBoxPassword;
        private Label labelCode;
        private Button buttonSendCode;
        private MaskedTextBox maskedTextBoxCode;
        private MaskedTextBox maskedTextBoxPhone;
        private Button buttonCancel;
        private ProgressBar progressBar;
    }
}